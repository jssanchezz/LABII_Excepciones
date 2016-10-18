using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Auto
    {
        public string marca;
        public int numero;
        public List<Rueda> ruedas;

        public Auto(string marca, int numero)
        {
            this.marca = marca;
            this.numero = numero;
            this.ruedas = new List<Rueda>();
        }

        public void Andar()
        {
            if (ruedas.Count < 4)
            {
                throw new MiException("Ruedas insuficientes.", DateTime.Now);
            }            
            else
            {
                try
                {
                    foreach (Rueda item in this.ruedas)
                    {
                        item.Rodar();
                    }
                }
                catch (PinchaduraException ex)
                {

                    throw new AutoException("algo", ex.hora, this, ex);
                }

                
            }
        }
    }
}
