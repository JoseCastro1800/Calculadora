using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Valores
    {
        //Vamos a instanciar y a encapsular los objetos 
        private double valorA;
        private double valorB;
        private string operaciones;
        private double resultado;


        public double ValorA
        {
            get { return valorA; }
            set { valorA = value; }
        }

        public double ValorB
        {
            get { return valorB; }
            set { valorB = value; }

        }

        public string Operaciones
        {
            get { return operaciones; }
            set { operaciones = value; }
        }
        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }

}
