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

                    currentMembership = search.Include(m => m.Titular).ToList();

                    return currentMembership;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la membresia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
