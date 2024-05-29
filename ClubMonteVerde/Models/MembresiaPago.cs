using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Models
{
    [Table("membresia_pagos")]
    public class MembresiaPago
    {
        [Key]
        public int? id { get; set; }
        public int? membresia_id { get; set; }
        public DateTime? fecha_pago { get; set; }
        public string? mes_pago { get; set; }
        public int? pases_asignados { get; set; }
        public DateTime? vigencia { get; set; }
        public string? folio1 { get; set; }
        public string? folio2 { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}
