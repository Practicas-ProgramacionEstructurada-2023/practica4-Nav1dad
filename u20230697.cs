using System;
using System.ComponentModel;
using System.Data;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            Console.WriteLine("\n<<<<<<<<< ESTRUCTURAS DE CONTROL SELECCTIVS EN C# >>>>>>>>>>");
            Console.WriteLine("\nOPCIONES:");
            Console.WriteLine("1. Determinar si el numero es positivo o si es negativo o igual a 0");
            Console.WriteLine("2. Mostrar fecha y hora actual");
            Console.WriteLine("3. Determinar si puede votar y conducir legalmente");
            Console.WriteLine("4. Determinar si el numero es par o impar");
            Console.WriteLine("\nELIGA UNA OPCION:");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1){
                Console.WriteLine("Ingrese un numero:");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu numero es positivo\n");
                }

                else if (numero < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu numero es negativo\n");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu numero es igual a 0\n");
                }
            }
            else if (opcion == 2){
                Console.ForegroundColor = ConsoleColor.Red;
                DateTime fechahora = DateTime.Now;
                Console.WriteLine("\nLa fecha y hora actual es: " + fechahora + "\n");
            }
            else{
                switch (opcion )
                {
                    case 3:
                    Console.WriteLine("\nIngrese su edad");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    
                    if (edad >= 18)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEres mayor de edad. Puedes votar y conducir legalmente\n");   
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nNo eres mayor de edad. No puede votar ni conducir legalmente\n");
                    }
                        break;

                    case 4:
                        Console.WriteLine("\nIngresa un numero");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        if (numero % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEl numero ingresado es par\n");
                        }
                        else {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEl mumero ingresado es impar\n");
                        }

                        break;
                    default:
                    Console.WriteLine("\nOpcion invalida intentelo de nuevo\n");
                        break;
                }
                
            }
            Console.ReadKey();
            Console.ResetColor();

        }
    }
}