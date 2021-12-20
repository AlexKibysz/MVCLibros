using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCLibros.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Orden de Vista")]
        [Range(1, 100, ErrorMessage = "El Orden de vista puede estar entre 1 y 100!")]
        public int DisplayOrder { get; set; }

        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
