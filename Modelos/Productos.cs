namespace TerraMarketPlace.API.Models
{
    public class Product
    {
        public int Id { get; set; } // Identificador único
        public string Name { get; set; } // Nombre del producto
        public string Description { get; set; } // Descripción del producto
        public decimal Price { get; set; } // Precio del producto
        public int Stock { get; set; } // Cantidad disponible en inventario
    }
}
