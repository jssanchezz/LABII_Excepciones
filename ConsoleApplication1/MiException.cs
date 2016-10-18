using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MiException:Exception
    {
        public DateTime hora;

        public MiException(string message, DateTime hora)
            : base(message)
        {
            this.hora = hora;
        }

        public MiException(string message, DateTime hora, Exception excepAnterior):base(message, excepAnterior)
        {
            this.hora = hora;
        }
    }
}
