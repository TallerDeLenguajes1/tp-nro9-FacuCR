using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helpers
{
    class ConversorDeMorse
    {

        public static string[] MorseATexto()
        {

            DateTime dt = DateTime.Now;
            string fecha = dt.ToString("dd-MM-yy");

            string morse;

            string traduccion = null;

            string ruta = @"C:\Users\Facundo\Desktop\Repositorio\tp-nro9-FacuCR\TrabajoPractico9\ConversorMorse\bin\Morse\morse_";

            string directorio = ruta + fecha + ".txt";

            string[] convertido = new string[50];

            int i = 0, cont = 0;

            if (File.Exists(directorio))
            {
                using (FileStream fileStream = new FileStream(directorio, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader leer = new StreamReader(fileStream))
                    {

                        while ((morse = leer.ReadLine()) != null)
                        {
                            if (morse == "")
                            {
                                cont++;

                                if (cont == 3)
                                {

                                    switch (traduccion)
                                    {
                                        case ".-":
                                            convertido[i] = "a";
                                            break;

                                        case "-...":
                                            convertido[i] = "b";
                                            break;

                                        case "-.-.":
                                            convertido[i] = "c";
                                            break;

                                        case "-..":
                                            convertido[i] = "d";
                                            break;

                                        case ".":
                                            convertido[i] = "e";
                                            break;

                                        case "..-.":
                                            convertido[i] = "f";
                                            break;

                                        case "--.":
                                            convertido[i] = "g";
                                            break;

                                        case "....":
                                            convertido[i] = "h";
                                            break;

                                        case "..":
                                            convertido[i] = "i";
                                            break;

                                        case ".---":
                                            convertido[i] = "j";
                                            break;

                                        case "-.-":
                                            convertido[i] = "k";
                                            break;

                                        case ".-..":
                                            convertido[i] = "l";
                                            break;

                                        case "--":
                                            convertido[i] = "m";
                                            break;

                                        case "-.":
                                            convertido[i] = "n";
                                            break;

                                        case "---":
                                            convertido[i] = "o";
                                            break;

                                        case ".--.":
                                            convertido[i] = "p";
                                            break;

                                        case "--.-":
                                            convertido[i] = "q";
                                            break;

                                        case ".-.":
                                            convertido[i] = "r";
                                            break;

                                        case "...":
                                            convertido[i] = "s";
                                            break;

                                        case "-":
                                            convertido[i] = "t";
                                            break;

                                        case "..-":
                                            convertido[i] = "u";
                                            break;

                                        case "...-":
                                            convertido[i] = "v";
                                            break;

                                        case ".--":
                                            convertido[i] = "w";
                                            break;

                                        case "-..-":
                                            convertido[i] = "x";
                                            break;

                                        case "-.--":
                                            convertido[i] = "y";
                                            break;

                                        case "--..":
                                            convertido[i] = "z";
                                            break;

                                        case "-----":
                                            convertido[i] = "0";
                                            break;

                                        case ".----":
                                            convertido[i] = "1";
                                            break;

                                        case "..---":
                                            convertido[i] = "2";
                                            break;

                                        case "...--":
                                            convertido[i] = "3";
                                            break;

                                        case "....-":
                                            convertido[i] = "4";
                                            break;

                                        case ".....":
                                            convertido[i] = "5";
                                            break;

                                        case "-....":
                                            convertido[i] = "6";
                                            break;

                                        case "--...":
                                            convertido[i] = "7";
                                            break;

                                        case "---..":
                                            convertido[i] = "8";
                                            break;

                                        case "----.":
                                            convertido[i] = "9";
                                            break;

                                        case " ":
                                            convertido[i] = " ";
                                            break;

                                        default:
                                            break;
                                    }

                                    i++;

                                    traduccion = null;
                                }
                            }

                            if (morse != "")
                            {

                                cont = 0;

                                traduccion += morse;
                            }

                        }
                    }  

                }

            }


            return convertido;

        }


        public static string TextoAMorse(string texto)
        {

            DateTime dt = DateTime.Now;
            string fecha = dt.ToString("dd-MM-yy");

            string ruta = @"C:\Users\Facundo\Desktop\Repositorio\tp-nro9-FacuCR\TrabajoPractico9\ConversorMorse\bin\Morse\morse_";

            string convertido = null;

            foreach (char letra in texto)
            {
                switch (letra)
                {
                    case 'a':
                    case 'A':
                        convertido = convertido + ".-\n";
                        break;

                    case 'b':
                    case 'B':
                        convertido = convertido + "-...\n";
                        break;

                    case 'c':
                    case 'C':
                        convertido = convertido + "-.-.\n";
                        break;

                    case 'd':
                    case 'D':
                        convertido = convertido + "-..\n";
                        break;

                    case 'e':
                    case 'E':
                        convertido = convertido + ".\n";
                        break;

                    case 'f':
                    case 'F':
                        convertido = convertido + "..-.\n";
                        break;

                    case 'g':
                    case 'G':
                        convertido = convertido + "--.\n";
                        break;

                    case 'h':
                    case 'H':
                        convertido = convertido + "....\n";
                        break;

                    case 'i':
                    case 'I':
                        convertido = convertido + "..\n";
                        break;

                    case 'j':
                    case 'J':
                        convertido = convertido + ".---\n";
                        break;

                    case 'k':
                    case 'K':
                        convertido = convertido + "-.-\n";
                        break;

                    case 'l':
                    case 'L':
                        convertido = convertido + ".-..\n";
                        break;

                    case 'm':
                    case 'M':
                        convertido = convertido + "--\n";
                        break;

                    case 'n':
                    case 'N':
                        convertido = convertido + "-.\n";
                        break;

                    case 'o':
                    case 'O':
                        convertido = convertido + "---\n";
                        break;

                    case 'p':
                    case 'P':
                        convertido = convertido + ".--.\n";
                        break;

                    case 'q':
                    case 'Q':
                        convertido = convertido + "--.-\n";
                        break;

                    case 'r':
                    case 'R':
                        convertido = convertido + ".-.\n";
                        break;

                    case 's':
                    case 'S':
                        convertido = convertido + "...\n";
                        break;

                    case 't':
                    case 'T':
                        convertido = convertido + "-\n";
                        break;

                    case 'u':
                    case 'U':
                        convertido = convertido + "..-\n";
                        break;

                    case 'v':
                    case 'V':
                        convertido = convertido + "...-\n";
                        break;

                    case 'w':
                    case 'W':
                        convertido = convertido + ".--\n";
                        break;

                    case 'x':
                    case 'X':
                        convertido = convertido + "-..-\n";
                        break;

                    case 'y':
                    case 'Y':
                        convertido = convertido + "-.--\n";
                        break;

                    case 'z':
                    case 'Z':
                        convertido = convertido + "--..\n";
                        break;

                    case '0':
                        convertido = convertido + "-----\n";
                        break;

                    case '1':
                        convertido = convertido + ".----\n";
                        break;

                    case '2':
                        convertido = convertido + "..---\n";
                        break;

                    case '3':
                        convertido = convertido + "...--\n";
                        break;

                    case '4':
                        convertido = convertido + "....-\n";
                        break;

                    case '5':
                        convertido = convertido + ".....\n";
                        break;

                    case '6':
                        convertido = convertido + "-....\n";
                        break;

                    case '7':
                        convertido = convertido + "--...\n";
                        break;

                    case '8':
                        convertido = convertido + "---..\n";
                        break;

                    case '9':
                        convertido = convertido + "----.\n";
                        break;

                    case ' ':
                        convertido = convertido + " \n";
                        break;

                    default:
                        Console.WriteLine("No se puede traducir a morse: " + letra);
                        break;
                }
            }

            string directorio = ruta + fecha + ".txt";

            if (!File.Exists(directorio))
            {
                FileStream fileStream = new FileStream(directorio, FileMode.CreateNew);

                fileStream.Close();
            }

            try
            {
                using (FileStream fs = new FileStream(directorio, FileMode.Open, FileAccess.Write))
                {
                    using (StreamWriter escribir = new StreamWriter(fs))
                    {
                        foreach (char letra in convertido)
                        {
                            escribir.Write(letra + "\n\r");
                        }
                    }
                }

            }
            catch
            {
                Console.WriteLine("Ocurrio un error!");
            }


            return convertido;

        }

    }
}
