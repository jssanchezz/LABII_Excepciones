using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PinchaduraException:MiException
    {
        public string marca;

        public PinchaduraException(string marca, string message, DateTime hora, Exception excepAnterior)
            : base(message, hora, excepAnterior)
        {
            this.marca = marca;
        }

        public PinchaduraException(string marca, string message, DateTime hora)
            : base(message, hora)
        {
            this.marca = marca;
        }
    }
}
