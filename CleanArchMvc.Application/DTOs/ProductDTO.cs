using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Description is required")]
        [MinLength(5)]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 999999)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The Stock is required")]
        [Range(1, 9999)]
        public int Stock { get; set; }

        [MaxLength(250)]
        public string Img { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string CategoryName { get; set; }
    }
}
