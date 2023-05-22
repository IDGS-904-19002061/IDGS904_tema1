using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace IDGS904_tema1.Models
{
    public class Traductor
    {
        public string en { get; set; }
        public string es { get; set; }

        public void save(Traductor obj)
        {
            var data = obj.en.ToUpper() + ":" + obj.es.ToUpper() + Environment.NewLine;

            var file = HttpContext.Current.Server.MapPath("~/App_Data/translation.txt");

            if (File.Exists(file))
            {
                File.AppendAllText(file, data);
            }
            else
            {
                File.WriteAllText(file, data);
            }
           
        }

        public Array read()
        {
            Array data = null;
            var file = HttpContext.Current.Server.MapPath("~/App_Data/translation.txt");
            if (File.Exists(file))
            {
                data = File.ReadAllLines(file);
            }
            return data;
        }
    }
}