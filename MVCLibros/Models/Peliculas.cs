using System.ComponentModel.DataAnnotations;

namespace MVCLibros.Models
{
    public class Peliculas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string EstudioFilmacion { get; set; }

    }
}
