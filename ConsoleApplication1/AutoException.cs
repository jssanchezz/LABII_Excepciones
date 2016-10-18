using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class AutoException:MiException
    {
        public Auto miAuto;

        public AutoException(string message, DateTime hora, Auto unAuto, Exception excepAnterior)
            : base(message, hora, excepAnterior)
        {
            this.miAuto = unAuto;        
        }
    }
}
