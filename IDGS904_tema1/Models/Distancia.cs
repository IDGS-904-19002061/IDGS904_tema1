using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Distancia
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }
        public double distancia { get; set; } 

        public double Calcular()
        {
            this.distancia = Math.Sqrt(Math.Pow(this.x2-this.x1, 2)+ Math.Pow(this.y2-this.y1, 2));

            return this.distancia;
        }

    }
}