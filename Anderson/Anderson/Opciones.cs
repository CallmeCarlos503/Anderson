﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anderson
{
    internal class Opciones
    {
        public Opciones() {
            Console.WriteLine("Bienvenido al sistema de opciones");
        }
        public void Captura()
        {
            try
            {
                double h, Epg, K;
                double m, g = 9.8; 
                double t;

                Console.Write("Ingrese la altura desde la que se deja caer el cuerpo (en metros): ");
                h = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la masa del cuerpo (en kilogramos): ");
                m = double.Parse(Console.ReadLine());

                t = Math.Sqrt(2 * h / g); 

                Epg = m * g * h; 

                K = 0.5 * m * Math.Pow(g * t, 2); 

                Console.WriteLine("El tiempo de caída es: " + t.ToString("0.00") + " segundos");
                Console.WriteLine("La energía potencial gravitacional del cuerpo es: " + Epg.ToString("0.00") + " joules");
                Console.WriteLine("Energia cinetica al llegar al piso: " + Epg.ToString("0.00") + " joules");
            }
            catch(Exception ex) { 
            }
        }
    }
}
