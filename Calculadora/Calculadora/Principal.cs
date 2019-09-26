using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Principal
    {
        public void menu()
        {
            Console.WriteLine("Bienvenido al menu de esta calculadora");
        }

        public void Salir()
        {
            Environment.Exit(0);
        }


        public void Menu_Calculadora()
        {
            Console.WriteLine("Escribe el nombre de la operacion que realizaras");
            Console.WriteLine("Suma");
            Console.WriteLine("Resta");
            Console.WriteLine("Division");
            Console.WriteLine("Multiplicacion");
            Console.WriteLine("Salir");
            int OP = Convert.ToInt32(Console.ReadLine());

            Operacion Me = new Operacion();
            if
            { 

                double P = 0;

        

                // Vamos a crear el switch para la operacion
                switch (OP)
                {

                    case 1:
                        Valores ResultadoSuma = new Valores();
                        Console.WriteLine("Ingrese los dos valores");
                        Console.WriteLine("Ingresa el Valor A");
                        ResultadoSuma.ValorA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el Valor B");
                        ResultadoSuma.ValorB = Convert.ToDouble(Console.ReadLine());

                        P = Me.Suma(ResultadoSuma);
                        Console.Clear();

                        break;


                    case 2:
                        Valores ResultadoResta = new Valores();
                        Console.WriteLine("Ingrese los dos valores");
                        Console.WriteLine("Ingresa el Valor A");
                        ResultadoResta.ValorA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el Valor B");
                        ResultadoResta.ValorB = Convert.ToDouble(Console.ReadLine());

                        P = Me.Resta(ResultadoResta);
                        Console.Clear();

                        break;

                    case 3:
                        Valores ResultadoM = new Valores();
                        Console.WriteLine("Ingrese los dos valores");
                        Console.WriteLine("Ingresa el Valor A");
                        ResultadoM.ValorA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el Valor B");
                        ResultadoM.ValorB = Convert.ToDouble(Console.ReadLine());

                        P = Me.Multiplicar(ResultadoM);
                        Console.Clear();

                        break;

                    case 4:
                        Valores ResultadoD = new Valores();
                        Console.WriteLine("Ingrese los dos valores");
                        Console.WriteLine("Ingresa el Valor A");
                        ResultadoD.ValorA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el Valor B");
                        ResultadoD.ValorB = Convert.ToDouble(Console.ReadLine());

                        P = Me.Divicion(ResultadoD);
                        Console.Clear();

                        break;

                    case 5:
                        Console.WriteLine("Salir");
                        Salir();

                        break;
                    default:
                        Console.WriteLine("Incorrecto");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }




            
        
        }


    

        }

    }
}
