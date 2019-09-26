using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacion
    {
        // Vamos a llamar al metodo de suma
        public double Suma(Valores suma)
        {

            double resultado = suma.ValorA + suma.ValorB;
            Console.WriteLine("El resultado es {0}", resultado);
            Console.ReadKey();
            Console.Clear();
            return resultado;

        }
        public double Resta(Valores restar)

        {
            double resultado = restar.ValorA - restar.ValorB;
            Console.WriteLine("El rsultado es {0}", resultado);
            Console.ReadKey();
            Console.Clear();
            return resultado;

        }
        public double Divicion(Valores dividir)

        {
            double resultado = dividir.ValorA / dividir.ValorB;
            Console.WriteLine("El rsultado es {0}", resultado);
            Console.ReadKey();
            Console.Clear();
            return resultado;

        }
        public double Multiplicar(Valores multiplicar)

        {
            double resultado = multiplicar.ValorA * multiplicar.ValorB;
            Console.WriteLine("El rsultado es {0}", resultado);
            Console.ReadKey();
            Console.Clear();
            return resultado;

        }
    }
}
