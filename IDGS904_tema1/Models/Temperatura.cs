using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Temperatura
    {
        public double Grados { get; set; }
        public string Select { get; set; }
        public double Res { get; set; }

        public void Convertir()
        {
            if (this.Select == "Celsius")
            {
                this.Res = (this.Grados - 32) / 1.8;
            }
            else
            {
                this.Res = (this.Grados * 1.8) + 32;
            }
        }
    }
}