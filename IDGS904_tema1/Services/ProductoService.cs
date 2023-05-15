using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class ProductoService
    {
        public List<Productos> ObtenerProductos()
        {
            return new List<Productos>
            {
                new Productos{
                    Nombre = "Pulque 1",
                    Descripcion = "Frutos rojos",
                    Cantidad = 10,
                    Produccion = new DateTime(2023, 5, 11)
                },
                new Productos{
                    Nombre = "Pulque",
                    Descripcion = "Mango piña",
                    Cantidad = 35,
                    Produccion = new DateTime(2023, 6, 10)
                }
            };
        }
    
}
}