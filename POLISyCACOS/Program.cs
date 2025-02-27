using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace POLISyCACOS { 

    public class asesino
{
        public double Convergencia(int metro)
        {
            return metro * 1.09361;
        }
        public double Convergencia(double yarda) {
            return yarda / 1.09361; 
        }
        public double Convergencia(double kilo, char simbolo )
        {
            return kilo * 35.274;
        }
        public double Convergencia(double onza, string duelo)
        {
            return onza / 35.274;
        }




    
}

    internal class Program
    {
        static void Main(string[] args)
        {
            asesino creacion = new asesino();
            Console.WriteLine("aqui para converger varios tipos de calculaciones");
            Console.WriteLine("de metro a yarda mijo    " + creacion.Convergencia(12));
            Console.WriteLine("de yarda a metro " + creacion.Convergencia(12.09));
            Console.WriteLine("de kilo a onza  " + creacion.Convergencia(12.15,'o'));
            Console.WriteLine("de onza a kilos  " + creacion.Convergencia(15.54, "kl"));
            Console.ReadLine();
                

        }
    }
}
