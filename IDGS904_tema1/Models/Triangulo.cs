using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Triangulo
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double x3 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double y3 { get; set; }
        public double area { get; set; }
        public bool triangle { get; set; }
        public string kindTriangle { get; set; }
        public List<double> sides { get; set; }

        public Triangulo validations(Triangulo obj)
        {
            if (obj.x1 == obj.x2 && obj.x2 == obj.x3)
            {
                obj.triangle = false;
            }
            else
            {
                obj.triangle = true;
                obj.kindTriangle = "Irregular";

                double dP1P2 = 0;
                double dP1P3 = 0;
                double dP2P3 = 0;

                dP1P2 = Math.Sqrt(((Math.Pow(obj.x2 - obj.x1, 2)) + (Math.Pow(obj.y2 - obj.y1, 2))));
                dP1P3 = Math.Sqrt(((Math.Pow(obj.x3 - obj.x1, 2)) + (Math.Pow(obj.y3 - obj.y1, 2))));
                dP2P3 = Math.Sqrt(((Math.Pow(obj.x3 - obj.x2, 2)) + (Math.Pow(obj.y3 - obj.y2, 2))));

                dP1P2 = Math.Round(dP1P2);
                dP1P3 = Math.Round(dP1P3);
                dP2P3 = Math.Round(dP2P3);

                List<double> list = new List<double>();
                list.Add(dP1P2);
                list.Add(dP2P3);
                list.Add(dP1P3);
                obj.sides = list;
                list.Sort();


                if (dP1P2 == dP2P3 || dP1P2 == dP1P3 || dP2P3 == dP1P3)
                {
                    double b = 0;
                    double a = 0;
                    double h = 0;

                    obj.kindTriangle = "Isosceles";

                    if (list[0] != list[1])
                    {
                        a = list[1];
                        b = list[0];

                        h = list[0];
                    }else
                    {
                        b = list[2];
                        a = list[0];

                        
                    }

                    h = Math.Sqrt((Math.Pow(a, 2)-(Math.Pow(b,2)/4)));
                    obj.area = (b * h) / 2;

                }
                if (Math.Pow(list[0], 2) + Math.Pow(list[1], 2) == Math.Pow(list[2], 2))
                {
                    obj.kindTriangle = "Rectangulo";
                    obj.area = (list[0] * list[1])/2;

                }
                if (dP1P2 == dP2P3 && dP2P3 == dP1P3)
                {
                    double h = 0;
                    obj.kindTriangle = "Equilatero";
                    h = (Math.Sqrt(3) * dP1P2) / 2;
                    obj.area = (dP1P2 * h) / 2;
                }
            }

            return obj;
        }







    }
}