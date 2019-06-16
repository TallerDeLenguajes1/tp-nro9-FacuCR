using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codificando
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Ingrese un texto para traducir a morse");

            texto = Console.ReadLine();

            Conversor.TextoAMorse(texto);

            Conversor.MorseSonido();


        }
    }
}
