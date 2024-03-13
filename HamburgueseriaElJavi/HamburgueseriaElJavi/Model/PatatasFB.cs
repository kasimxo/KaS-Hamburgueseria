using MyBurguerLib_Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgueseriaElJavi.Model
{
    internal class PatatasFB
    {
        public string corte { get; set; } 
        public string dressing { get; set; }
        public string name { get; set; }
        public Boolean sal {  get; set; }
        public string tipo { get; set; }

        public string img {  get; set; }

        public Patatas toPatatas()
        {
            return new Patatas(name, sal, tipo, corte, dressing);
        }
    }
}
