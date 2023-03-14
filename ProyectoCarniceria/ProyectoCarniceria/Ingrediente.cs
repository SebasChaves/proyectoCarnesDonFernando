using System;
using System.Collections.Generic;

namespace ProyectoCarniceria
{
    public partial class Ingrediente
    {
        public Ingrediente()
        {
            Receta = new HashSet<Receta>();
        }

        public int IdIngrediente { get; set; }
        public string Descripcion { get; set; } = null!;
        public int IdReceta { get; set; }

        public virtual ICollection<Receta> Receta { get; set; }
    }
}
