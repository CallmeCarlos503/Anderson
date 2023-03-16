using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anderson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
              
                Opciones opciones = new Opciones();
                opciones.Captura();

                Console.ReadKey();
            }   
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }
        public void mensaje()
        {
            Console.WriteLine("puto");
        }
       

    }
}
