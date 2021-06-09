using System;

namespace tp5taller
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingresar un numero para invertir mayor que cero");
            do
            {
                 num = int.Parse(Console.ReadLine());

            }while(num <=0);

           Console.WriteLine("El numero invertido queda asi: "+ Invertir(num));
            
        }

        static int Invertir(int num)
        {
            int invertido=0;
            while (num>0)
            {
                invertido = invertido * 10 + (num%10);
                num = num / 10;
            }


            return invertido;
        }
    }
}
