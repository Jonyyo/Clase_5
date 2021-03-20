using System;
using System.Threading;

namespace Clase_5
{
    class Program
    {

        public static string Mid(string parametro, int startindex, int lenght) //funcion
        {
            String result = parametro.Substring(startindex, lenght); //Crea sub cadena apartando los caracteres

            return result;
        }

        static void Main(string[] args)
        {
            string NOMBRE;
            string LetraNombre;
            int MovimientoColumnas = 0;
            int Movimientocaracteres = 0;
            int NCaracteresNombre = 0;
            int DistanciaMovimmientoDerecha = 0;
            Console.WriteLine("Ingrese su nombre: ");
            NOMBRE = Console.ReadLine();
            Console.SetCursorPosition(1, 12);
            Console.Write(NOMBRE);
            NCaracteresNombre = NOMBRE.Length;
            DistanciaMovimmientoDerecha = 70;
            NOMBRE = NOMBRE.ToUpper();
            for (Movimientocaracteres=NOMBRE.Length; Movimientocaracteres>=1; Movimientocaracteres--)
            {
                LetraNombre = Mid(NOMBRE, Movimientocaracteres - 1, 1);
                for (MovimientoColumnas=NCaracteresNombre;MovimientoColumnas<=DistanciaMovimmientoDerecha;MovimientoColumnas++)
                {
                    Console.SetCursorPosition(MovimientoColumnas, 12);
                    Console.Write(" " + LetraNombre);
                    Thread.Sleep(50);

                }
                DistanciaMovimmientoDerecha--;
                NCaracteresNombre--;


            }
            Console.ReadKey();
        }
    }
}
