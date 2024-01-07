using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_dio.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }


         public string Numero { get; set; }
         private string Modelo {get; set;}
         private string IMEI {get; set;}
         private int Memoria {get; set;}
         

         public virtual void Apresentar()
         {
            Console.WriteLine($"Número : {Numero} | Modelo : {Modelo} | IMEI : {IMEI} | Memoria : {Memoria}");
         }
        public void Ligar()
        {
            Console.WriteLine($"Ligando para {Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação de {Numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}