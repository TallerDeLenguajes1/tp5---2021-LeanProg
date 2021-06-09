using System;

namespace punto3tp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("ingrese cadena");
            cadena = Console.ReadLine();
            Console.WriteLine(cadena);
            Operaciones(cadena);
        }

        static void Operaciones(string cadena)
        {
            string cadena2;
            string cadena3;
            Console.WriteLine("longitud de cadena: "+(cadena.Length));
            Console.WriteLine("Sub cadena: " + (cadena.Substring(3, 6)));
            Console.WriteLine("caracter en la posicion 2: "+(cadena.Substring(1,1)));
            Console.WriteLine("introduzca una cadena para concaquetar: ");
            cadena2 = Console.ReadLine();
            Console.WriteLine(string.Concat(cadena,cadena2));
            Console.WriteLine("Caracteres de una cadena");
            foreach (char i in cadena)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("introduzca la palabra que desea buscar: ");
            cadena3 = Console.ReadLine();
            Console.WriteLine(cadena.Contains(cadena3));
            Console.WriteLine(cadena.ToUpper());
            Console.WriteLine(cadena.ToLower());
            Console.WriteLine("Introduzca la expresion de suma con 2 numeros: ");
            cadena3 = Console.ReadLine();
            string[] vectorcadena = cadena3.Split('+');
            foreach (string i in vectorcadena)
            {
                Console.WriteLine(i);
            }
            int suma = int.Parse(vectorcadena[0]) + int.Parse(vectorcadena[1]);
            Console.WriteLine("Suma= "+ suma);

        }

    }


}
