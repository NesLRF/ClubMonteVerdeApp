using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Classes.Membership
{
    public class ShowMembershipFamiliarData
    {
        [Key]
        public string? Membresia { get; set; }

        [Display(Name = "Numero de membresía falimiar")]
        public string? MembresiaFamiliarFolio { get; set; }

        [Display(Name = "Nombre de falimiar")]
        public string? MembresiaFamiliarNombre { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        public DateTime? MembresiaFamiliarNacimiento { get; set; }

        [Display(Name = "Grado familiar")]
        public string? MembresiaFamiliarGradoFamiliar { get; set; }

        [Display(Name = "Estatus")]
        public string? MembresiaFamiliarEstatus { get; set; }
    }
}
