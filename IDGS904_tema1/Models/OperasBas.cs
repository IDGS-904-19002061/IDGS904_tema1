using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public int Res { get; set; }

        public int Opera { get; set; }

        public int main()
        {
            switch (this.Opera)
            {
                case (0):
                    this.Res = this.Num1 + this.Num2;
                    break;
                case (1):
                    this.Res = this.Num1 - this.Num2;
                    break;
                case (2):
                    if (this.Num2 != 0)
                    {
                        this.Res = this.Num1 / this.Num2;
                    }

                    break;
                case (3):
                    this.Res = this.Num1 * this.Num2;
                    break;
            }

            return this.Res;
        }

    }
}