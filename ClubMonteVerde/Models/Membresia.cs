using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Models
{
    [Table("membresias")]
    public class Membresia
    {
        [Key]
        public int? id { get; set; }
        public string? numero_membresia_principal { get; set; }

        [Required]
        public string? tipo_membresia { get; set; }
        public DateTime? fecha_baja { get; set; }
        public int? socio_titular_id { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }

        /* Belongs to*/
        public Socio? Titular { get; set; }

        /* Belongs to many*/
        public IList<MembresiaPase>? Pases { get; set; }
        public IList<MembresiaFamiliar>? Familiares { get; set; }
    }
}
