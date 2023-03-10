
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class ProductoViewModel
    {

        public int IdCategoria { get; set; }
        [Display(Name = "Categoría")]
        public int IdProducto { get; set; }
        [Display(Name = "Producto")]
        public string Nombre { get; set; } = null!;
        public int Precio { get; set; }
        public string DescripcionProductoLarga { get; set; } = null!;
        public string DescripcionProductoCorta { get; set; } = null!;
        public int Cantidad { get; set; }
        public string UrlImg { get; set; } = null!;
    }
    
}
