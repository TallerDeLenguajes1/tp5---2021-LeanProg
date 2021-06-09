using System;

namespace punto2tp5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int opcion;
            
            do
            {

                Console.WriteLine("BIENVENIDO A SU CALCULADORA MODERNA POR FAVOR SELECCIONE LA OPCION QUE DESEA REALIZAR");
                Console.WriteLine("---sumar teclee 1--");
                Console.WriteLine("---resta teclee 2--");
                Console.WriteLine("---division teclee 3--");
                Console.WriteLine("---multiplicacion teclee 4--");
                Console.WriteLine("---Valor Absoluto teclee 5--");
                Console.WriteLine("---El cuadrado  teclee 6--");
                Console.WriteLine("---Raiz cuadrada teclee 7--");
                Console.WriteLine("---Seno teclee 8--");
                Console.WriteLine("---coseno teclee 9--");
                Console.WriteLine("---Parte Entera de un Tipo decimal teclee 10--");



                Console.WriteLine("---Salir de la calculadora  teclee 0--");

                opcion = int.Parse(Console.ReadLine());
                if (opcion!=0)
                {

                    calculadora(opcion);
                }
            } while (opcion != 0);
            


        }

        static void calculadora(int opcion)
        {
             int num1, num2;
             float num3;

            if (opcion < 5)
            {
                Console.WriteLine("Ingrese numero 1");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese numero 2");
                num2 = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("Suma= " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("resta= " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Division =" + (num1 / num2));
                        break;
                    case 4:
                        Console.WriteLine("Multiplicacion= " + (num1 * num2));
                        break;
                }
            }
            else
            {

                Console.WriteLine("Ingrese el numero: ");
                num3 = float.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 5:
                        Console.WriteLine("absoluto= " + (num3=Math.Abs(num3)));
                        break;
                    case 6:
                        Console.WriteLine("cuadrado= " + (Math.Pow(num3,2)));
                        break;
                    case 7:
                        Console.WriteLine("raiz cuadrada =" + (Math.Sqrt(num3)));
                        break;
                    case 8:
                        Console.WriteLine("seno= " + (Math.Sin(num3)));
                        break;
                    case 9:
                        Console.WriteLine("coseno= " + (Math.Cos(num3)));
                        break;
                    case 10:
                        Console.WriteLine("parte entera= " + (Math.Round(num3)));
                        break;
                }
            }

           
                
            


            
        }
    }
}
