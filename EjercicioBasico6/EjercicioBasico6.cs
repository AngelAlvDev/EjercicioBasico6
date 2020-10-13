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
            Int16 sietes = 0;
            Console.Write("Introduzca el numero a analizar: ");
            Int16 numero = (Int16)Console.Read();
            do
            {
                if (numero == '7')
                {
                    sietes++;
                }
                numero = (Int16)Console.Read();
            } while (numero != '\n');
            Console.WriteLine("El número de 7 introducido es " + sietes);
        }
    }
}
