using MyBurguerLib_Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgueseriaElJavi.Model
{
    internal class BebidasFB
    {
        public Boolean alcohol {  get; set; }
        public Boolean burbujas { get; set; }
        public string name { get; set; }
        public string sabor {  get; set; }

        public Bebida toBebida()
        {
            return new Bebida(name,alcohol,burbujas, sabor);
        }
    }
}
