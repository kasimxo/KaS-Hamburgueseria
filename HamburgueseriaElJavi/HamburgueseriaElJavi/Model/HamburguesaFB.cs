using MyBurguerLib_Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgueseriaElJavi.Model
{
    internal class HamburguesaFB
    {
        public string name { get; set; }    
        public Boolean bacon {  get; set; }
        public string carne { get; set; }
        public Boolean cebolla { get; set; }
        public Boolean huevo { get; set; }
        public Boolean queso { get; set; }
        public Boolean tomate { get; set; }

        public Hamburguesa toHamburguesa() {
            
            return new Hamburguesa(name, carne[0], tomate, queso, huevo, cebolla, bacon);
        }
    }
}
