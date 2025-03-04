using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Server_App.Model
{
    internal class Libro
    {

        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public float price { get; set; }
        public string currency { get; set; }
        public bool rent_available { get; set; }
        public int id_wh_av { get; set; } // ? id wharehouse
        public int id_lib_av { get; set; } // id library ? id library
        public int id_bs_av { get; set; } // book stock ? id bookstore


    }
}
