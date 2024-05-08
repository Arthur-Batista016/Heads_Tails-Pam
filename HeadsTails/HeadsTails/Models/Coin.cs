using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsTails.Models
{
    internal class Coin
    {
        private string lado;

        public string Lado { get; set; }
        public string LadoEscolhido { get; set; }


        public Coin()
        {
        }


        public String Jogar()
        {
            //operador Ternario (?) basicamnete um if resumido (sempre devolve valor)//
            return (new Random().Next(0, 2) == 0) ? "Cara" : "Coroa";
        }



    }
}

