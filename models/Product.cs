using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Product//● Crea una clase Producto con propiedades Nombre y Precio.

    {
        private string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name.ToLower();
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string newName)
        {
            Name = newName.ToLower();
        }
    }
}