using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Models
{
    [Table("entradas")]
    public class Entrada
    {
        [Key]
        public int? id { get; set; }
        public int? socio_id { get; set; }
        public int? familiar_id { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }

        public Socio? Socio { get; set; }
        public MembresiaFamiliar? Familiar { get; set; }
    }
}
