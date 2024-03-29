﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cine__backend.Models
{
    public class BookEntry
    {
        [Key]
        public Guid Id { get; set; }
        [Range(0,10000.00, ErrorMessage = "El valor asignado no está en el rango válido(0,10000.00)")]
        public double? Income { get; set; }
        [Range(0, 10000.00, ErrorMessage = "El valor asignado no está en el rango válido(0,10000.00)")]
        public double? Expense { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
    }

    public enum PaymentMethod
    {
        efectivo,
        crédito
    }
}
