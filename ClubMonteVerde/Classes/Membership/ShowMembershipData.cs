using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Classes.Membership
{
    public class ShowMembershipData
    {
        [Key]
        public string? Membresia { get; set; }

        [Display(Name = "Tipo de membresía")]
        public string? MembresiaTipo { get; set; }

        [Display(Name = "Titular de la membresía")]
        public string? MembresiaTitular { get; set; }

        [Display(Name = "Titulo del titular")]
        public string? MembresiaTitularTitulo { get; set; }

        [Display(Name = "Grado familiar de titular")]
        public string? MembresiaTitularGradoFamiliar { get; set; }
        
        [Display(Name = "Estatus de titular")]
        public string? MembresiaTitularEstatus {  get; set; }

        [Display(Name = "Fecha de baja")]
        public DateTime? MembresiaFechaBaja { get; set; }

        public List<ShowMembershipFamiliarData>? Familiares { get; set; }
    }
}
