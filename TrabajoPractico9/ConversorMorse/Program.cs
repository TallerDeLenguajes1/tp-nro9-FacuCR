using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Helpers;

namespace ConversorMorse
{
    class Program
    {

        const int MAX = 50;

        static void Main(string[] args)
        {
            string texto;
            string[] morse = new string[MAX];
            string convertido;
            string[] convertidoMorse = new string[MAX];

            Console.WriteLine("Ingrese un texto para traducir a morse");

            texto = Console.ReadLine();

            convertido = ConversorDeMorse.TextoAMorse(texto);

            Console.WriteLine(convertido);

            convertidoMorse = ConversorDeMorse.MorseATexto();

            Console.WriteLine("El codigo morse traducido del texto es:");

            foreach (string letra in convertidoMorse)
            {
                Console.Write(letra);
            }

            Console.Write("\n");




        }
    }
}
