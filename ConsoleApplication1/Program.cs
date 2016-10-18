using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Throw = lanza la excepcion;
            Carrera miCarrera = new Carrera("Palermo");

            miCarrera.CorrerCarrera();

            Auto auto1 = new Auto("chrevrolet", 11);
            Auto auto2 = new Auto("ford", 12);
            Auto auto3 = new Auto("audi", 13);
            Auto auto4 = new Auto("ferrari", 14);

            auto1.ruedas.Add(new Rueda("1"));
            auto1.ruedas.Add(new Rueda("2"));
            auto1.ruedas.Add(new Rueda("3"));
            auto1.ruedas.Add(new Rueda("4"));

            auto2.ruedas.Add(new Rueda("1"));
            auto2.ruedas.Add(new Rueda("2"));
            auto2.ruedas.Add(new Rueda("3"));
            auto2.ruedas.Add(new Rueda("4"));

            auto3.ruedas.Add(new Rueda("1"));
            auto3.ruedas.Add(new Rueda("2"));
            auto3.ruedas.Add(new Rueda("3"));
            auto3.ruedas.Add(new Rueda("4"));

            auto4.ruedas.Add(new Rueda("1"));
            auto4.ruedas.Add(new Rueda("2"));
            auto4.ruedas.Add(new Rueda("3"));
            auto4.ruedas.Add(new Rueda("4"));

            miCarrera.listaAutos.Add(auto1);
            miCarrera.listaAutos.Add(auto2);
            miCarrera.listaAutos.Add(auto3);
            miCarrera.listaAutos.Add(auto4);

            try
            {
                miCarrera.CorrerCarrera();
            }
            catch (PinchaduraException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (AutoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MiException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
            
        }
    }
}
