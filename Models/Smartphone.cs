using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_net_poo.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        //Constutor 
        public Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar(){
            Console.WriteLine("Ligando.....");
        }

        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação....");
        }

        public abstract void InstalarAplicativo (string nomeApp);
    }
}