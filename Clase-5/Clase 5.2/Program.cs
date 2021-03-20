using System;

namespace Clase_5._2
{
    class Program
    {

        public static string generaletra(int min, int max)
        {
            Random ram = new Random();

            int NUM = Convert.ToInt32(ram.Next(65,122));
            
            string letraRespuesta = " ";
            if ((NUM > min) & (NUM < max))
            {
                letraRespuesta = Convert.ToString((char)NUM);
                
            }

            return letraRespuesta;
        }

        static void Main(string[] args)
        {
            byte CAN, K;
            string linea;
            Console.Write("Cuantos numeros?");
            linea = Console.ReadLine();
            CAN = byte.Parse(linea);
           
            string letra = ""; 

            for(K=1; K<=CAN; K++)
            {
                letra = generaletra(0, 256);
                Console.WriteLine($"letra generada {letra}");
            }


        }
    }
}
