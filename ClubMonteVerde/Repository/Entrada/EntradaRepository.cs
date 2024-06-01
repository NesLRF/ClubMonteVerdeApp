using ClubMonteVerde.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Repository.Entrada
{
    public class EntradaRepository
    {
        public IList<Membresia>? GetMembership(string qrValue)
        {
            try
            {
                IList<Membresia> currentMembership;
                using (var context = new EntradaContext())
                {
                    var search = from membership in context.membresia
                                 where membership.numero_membresia_principal == qrValue
                                 select membership;

                    currentMembership = search
                                        .Include(m => m.Titular)
                                        .ThenInclude(p => p.Estatus)
                                        .Include(m => m.Familiares)
                                        .ThenInclude(p => p.Estatus)
                                        .ToList();

                    return currentMembership;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la membresia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public (IList<Membresia>?, string?) GetFamiliarMembership(string qrValue)
        {
            try
            {
                IList<Membresia> currentMembership;
                using (var context = new EntradaContext())
                {
                    var search = from familiarMembership in context.membresiaFamiliar
                                 where familiarMembership.numero_membresia_secundaria == qrValue
                                 select familiarMembership;

                    var result = search.Include(mf => mf.Membresia).Include(mf => mf.Estatus);

                    if (!result.Any())
                    {
                        return (null, null);
                    }

                    var familiar = result.First();

                    SaveFamiliarEntrada((int)familiar.id!);



                    int? membsershipID = familiar.Membresia!.id;

                    var searchmembership = from membership in context.membresia
                                            where membership.id == membsershipID
                                            select membership;

                    currentMembership = searchmembership
                                        .Include(m => m.Titular)
                                        .ThenInclude(p => p.Estatus)
                                        .Include(m => m.Familiares)
                                        .ThenInclude(p => p.Estatus)
                                        .ToList();

                    string? userData = familiar.nombre_familiar + "," + familiar.grado_familiar + "," + familiar.Estatus!.nombre;

                    return (currentMembership, userData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la membresia del familiar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }
        }

        public void SaveSocioEntrada(int socioID)
        {
            try
            {
                using (var context = new EntradaContext())
                {
                    Models.Entrada entrada = new()
                    {
                        socio_id = socioID,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };

                    context.entrada.Add(entrada);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la entrada del socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SaveFamiliarEntrada(int familiarID)
        {
            try
            {
                using (var context = new EntradaContext())
                {
                    Models.Entrada entrada = new()
                    {
                        familiar_id = familiarID,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };

                    context.entrada.Add(entrada);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la entrada del socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
