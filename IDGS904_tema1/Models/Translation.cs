using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace IDGS904_tema1.Models
{
    public class Translation
    {
        public bool english {  get; set; }
        public bool spanish {  get; set; }
        public string word { get; set; }

        public String read(Translation obj)
        {
            Array data = null;
            var file = HttpContext.Current.Server.MapPath("~/App_Data/translation.txt");
            if (File.Exists(file))
            {
                data = File.ReadAllLines(file);
            }
            Array lines = null;

            string tmp = "";

            foreach (string item in data)
            {
                
                if (obj.word.ToUpper() == item.Split(':')[0] && obj.english == true)
                {
                    tmp = item.Split(':')[1];
                }
                else if (obj.word.ToUpper() == item.Split(':')[1] && obj.spanish == true)
                {
                    tmp = item.Split(':')[0];
                }
                else
                {
                    tmp = "No se ha encontrado";
                }
            }
            return tmp;
        }
    }
}