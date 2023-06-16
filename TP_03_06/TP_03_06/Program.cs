using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;
/*

Conociendo la implementación de los siguientes métodos:
Console.SetCursorPosition(int32 x, int32 y); Este método posiciona el cursor en
los valores indicados en x e y.
Thread.Sleep(tiempo en milisegundo); Este método permite realizar una pausa en la
ejecución del programa según el tiempo indicado entre paréntesis en milisegundos. Para
utilizar el método deberán importar el espacio de nombre System.Threading mediante la
línea using System.Threading;
Console.Clear(); Limpia la pantalla, borra su contenido.
Realizar un programa que permita visualizar la palabra “Nave” desplazándose por la mitad de la
pantalla. Y que al pulsar la tecla “B” (bomba) la Nave suelte un proyectil “I” (letra I), el cual deberá
caer hacia la parte inferior de la pantalla. 

*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 50;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("_===_");
                Thread.Sleep(50);
                Console.Clear();
                i++;

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.B)
                    {
                        //Muestro la ubicacion de la nave en la posicion que se detuvo
                        Console.SetCursorPosition(i, 0);
                        Console.WriteLine("_===_");
                        //Me guardo la ubicacion del cursor en la variable ubicacionNave para lanzar el misil desde esa ubicacion
                        //++2 para que el misil salga de la parte central de la nave
                        int ubicacionNave = i+2;
                        for (i = 1; i <= 10; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(ubicacionNave, i);
                            Console.WriteLine("I\n");
                            Thread.Sleep(100);
                        }
                        Console.SetCursorPosition(ubicacionNave-5, i);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("__---__---__");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("_______________________________________________________________________________________________" +
                            "_______________________________________________________________________________________________" +
                            "___________________________");

                        Console.WriteLine("_______________________________________________________________________________________________" +
                            "_______________________________________________________________________________________________" +
                            "___________________________");

                        Console.WriteLine("_______________________________________________________________________________________________" +
                            "_______________________________________________________________________________________________" +
                            "___________________________");

                        break;
                    }
                }
                //Limito el rango que se movera el curso, en este caso desde la posicion 50 hasta la posicion 150 para que no se mueva infinitamente
                if (i == 150)
                {
                    i = 50;
                }
            }
            Console.ResetColor();
            //Metodo para frenar el programa hasta presionar una tecla
            Console.WriteLine("\nPresione una tecla para finalizar el programa...");
            Console.ReadKey();
        }
    }
}