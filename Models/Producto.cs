using System.ComponentModel.DataAnnotations;

namespace ModelosMigracionesEnAula.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; } = 0;
    }
}
