using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LaPacaJerseys.Models
{
    public class Jersey : Controller
    {
        public int Id { get; set; }

        [Required]
        public required string SKU { get; set; }

        [Required]
        public required string Nombre { get; set; }

        [Required]
        public required string Equipo { get; set; }

        [Required]
        public required string Talla { get; set; }

        public decimal Precio { get; set; }

        [Required]
        public required string Imagen { get; set; }
    }
}
 