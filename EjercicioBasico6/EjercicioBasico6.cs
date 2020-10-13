using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico6
{
    class EjercicioBasico6
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el numero a analizar: ");
            String cadena = Console.ReadLine();
            Int16 sietes = 0;
            foreach(Char numero in cadena){
                if (numero == '7') {
                    sietes++;
                }
            }
            Console.WriteLine("El número de 7 introducido es " + sietes);
        }
    }
}
