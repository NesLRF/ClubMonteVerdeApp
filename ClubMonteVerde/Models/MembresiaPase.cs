using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Models
{
    [Table("membresia_pases")]
    public class MembresiaPase
    {
        [Key]
        public int? id { get; set; }

        [Required]
        public int? membresia_id { get; set; }

        public bool? familiar_invita { get; set; }

        public int? socio_id { get; set; }
        public int? familiar_id { get; set; }

        public string? folio { get; set; }
        public string? nombres_invitado { get; set; }
        public string? apellidos_invitado { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }

        /* Belongs to */
        public Membresia? Membresia { get; set; }
        public Socio? Socio { get; set; }
        public MembresiaFamiliar? Familiar { get; set; }
    }
}
