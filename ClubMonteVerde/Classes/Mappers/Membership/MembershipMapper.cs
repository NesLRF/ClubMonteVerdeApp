using ClubMonteVerde.Classes.Membership;
using ClubMonteVerde.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Classes.Mappers.Membership
{
    public class MembershipMapper
    {
        public IList<ShowMembershipData> GetMembershipMap(IList<Membresia> memberships)
        {
            var membershipFormat = new List<ShowMembershipData>();

            foreach (var membership in memberships)
            {
                ShowMembershipData membershipData = new()
                {
                    Membresia = membership.numero_membresia_principal,
                    MembresiaTipo = membership.tipo_membresia,
                    MembresiaTitular = membership.Titular!.nombres +" "+membership.Titular.apellidos,
                    MembresiaTitularTitulo = membership.Titular.titulo,
                    MembresiaTitularGradoFamiliar = membership.Titular.grado_familiar,
                    MembresiaTitularEstatus = membership.Titular.Estatus!.nombre,
                    MembresiaFechaBaja = membership.fecha_baja,
                    Familiares = []
                };

                if (membership.Familiares.Any())
                {
                    var familiares = new List<ShowMembershipFamiliarData>();

                    foreach (var familiar in membership.Familiares)
                    {
                        ShowMembershipFamiliarData membershipFamiliarData = new()
                        {
                            Membresia = membership.numero_membresia_principal,
                            MembresiaFamiliarFolio = familiar.numero_membresia_secundaria,
                            MembresiaFamiliarNombre = familiar.nombre_familiar,
                            MembresiaFamiliarNacimiento = familiar.fecha_nacimiento,
                            MembresiaFamiliarGradoFamiliar = familiar.grado_familiar,
                            MembresiaFamiliarEstatus = familiar.Estatus.nombre
                        };

                        familiares.Add(membershipFamiliarData);
                    }

                    membershipData.Familiares = familiares;
                }

                membershipFormat.Add(membershipData);
            }

            return membershipFormat;
        }
    }
}
