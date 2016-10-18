using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Rueda
    {
        public string marca;
        private static Random numeroRandom;

        public Rueda(string marca)
        {
            this.marca = marca;
        }

        static Rueda()
        {
            numeroRandom = new Random();
        }

        public void Pinchar()
        {
            throw new PinchaduraException(this.marca, "RuedaPinchada", DateTime.Now);
        }

        public void Rodar()
        {
            int numero;
            
            numero = numeroRandom.Next(1, 10);
            if (numero == 5)
                this.Pinchar();
            else
                Console.WriteLine("Numero: " + numero);
        }
    }
}
