using System;
using System.Threading;

namespace Clase_5._1
{
    class Program
    {

        public static void dibuja(int cantidad)
        {
            int XEnVertical = 22;
            int Interrogacionhorizontal = 72;
            int EspacioFilas = 2;
            int EspacioColumnas = 2;
            int F, C, A;

            for(A=1; A<=cantidad; A++)
            {
                for(F=EspacioColumnas; F<=Interrogacionhorizontal; F++)
                {
                    Console.SetCursorPosition(F, XEnVertical); Console.Write("?");
                    Console.SetCursorPosition(F, EspacioFilas); Console.Write("?");

                }
                for(C=EspacioFilas;C<=XEnVertical;C++)
                {
                    Console.SetCursorPosition(EspacioColumnas, C);Console.Write("x");
                    Console.SetCursorPosition(Interrogacionhorizontal, C);Console.Write("x");
                }
                EspacioFilas=EspacioFilas+1;
                XEnVertical=XEnVertical-1;
                EspacioColumnas++;
                Interrogacionhorizontal--;
            }
        }

        static void Main(string[] args)
        {
            for (int tan = 1;tan<9;tan++)
            {
                dibuja(tan);
                Thread.Sleep(1000);
            }
            
        
        }
    }
}
