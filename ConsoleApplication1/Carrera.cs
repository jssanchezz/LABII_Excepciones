using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Carrera
    {
        public List<Auto> listaAutos;
        public string autodromo;

        public Carrera(string autodromo)
        {
            this.autodromo = autodromo;
            this.listaAutos = new List<Auto>();
        }

        public void CorrerCarrera()
        {
            if (this.listaAutos.Count == 0)
            {
                throw new MiException("Sin autos", DateTime.Now);
            }
            else
            {
                foreach (Auto item in this.listaAutos)
                {
                    item.Andar();
                }
            }
        }
    }
}
