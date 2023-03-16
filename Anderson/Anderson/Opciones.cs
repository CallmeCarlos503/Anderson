using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anderson
{
    internal class Opciones
    {
        double Vi, t, g, h, W;
        Vi = 0;
        public Opciones() {
            Console.WriteLine("Bienvenido al sistema de opciones");
        }
        public void Captura()
        {
            try
            {
                
                Console.WriteLine("****INSERTE LOS DATOS NECESARIOS PARA LA ALTURA VERTICAL****");
                Console.WriteLine("Inserte la velocida inicial");
                Vi = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserte  el tiempo");
                t = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserte de cuanto es la gravedad");
                g = double.Parse(Console.ReadLine());
                Console.WriteLine("****INSERTE LOS DATOS NECESARIOS PARA LA ENERGIA POTENCIAL GRAVITACIONAL****");
                Console.WriteLine("Escribe el peso");
                W= double.Parse(Console.ReadLine());
                Console.WriteLine("La altura vertical es de " + AlturaVertical(Vi,t,g));
                Console.WriteLine("La energia Potencial Gravitacional es de " + EnergiaPotencia(W));
            }
            catch(Exception ex) { 
            }
        }
        public Double AlturaVertical(Double Vi, Double t, Double g)
        {
            return Vi * t + 1 / 2 * g * Math.Pow(t, 2);
        }
        public Double EnergiaPotencia(Double w)
        {
            return AlturaVertical();
        }
    }
}
