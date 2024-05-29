using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Models
{
    [Table("socios")]
    public class Socio
    {
        [Key]
        public int? id { get; set; }
        public int? membresia_id { get; set; }
        public string? folio { get; set; }

        [Required]
        public string? nombres { get; set; }
        [Required]
        public string? apellidos { get; set; }

        public string? titulo { get; set; }
        public int? estatus_id { get; set; }
        public DateTime? fecha_nacimiento { get; set; }
        public string? sexo { get; set; }
        public string? grado_familiar { get; set; }
        public string? domicilio { get; set; }
        public decimal? telefono { get; set; }
        public string? correo { get; set; }
        public DateTime? fecha_baja { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }

        /* Belongs to */
        public Membresia? Membresia { get; set; }
        public Estatus? Estatus { get; set; }

        /* Belongs to many*/
        public IList<MembresiaPase>? Pases { get; set; }
    }
}
