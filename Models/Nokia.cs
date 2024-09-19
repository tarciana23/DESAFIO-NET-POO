using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_net_poo.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero){}
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando app em dispositivo da Nokia");
        }
    }
}