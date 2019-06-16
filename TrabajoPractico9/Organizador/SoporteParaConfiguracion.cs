using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion()
        {
            string rutaDeArchivo = @"C:\Users\Facundo\Desktop\Repositorio\tp-nro9-FacuCR\TrabajoPractico9\Organizador\bin\Debug\Configuracion.dat";

            string[] texto = { ".mp3", "\n", ".txt" };


            if (!File.Exists(rutaDeArchivo))
            {
                using (FileStream fs = new FileStream(rutaDeArchivo, FileMode.CreateNew))
                {
                    using (StreamWriter escribir = new StreamWriter(fs))
                    {
                        foreach (string linea in texto)
                        {
                            escribir.Write(linea);
                        }
                    }
                }
            }
            else
                Console.WriteLine($"El archivo de configuracion ya existe!");


        }


        public static void LeerConfiguracion(string[] extensiones)
        {

            string linea;

            string rutaDeArchivo = @"C:\Users\Facundo\Desktop\Repositorio\tp-nro9-FacuCR\TrabajoPractico9\Organizador\bin\Debug\Configuracion.dat";

            StreamReader leer = new StreamReader(rutaDeArchivo);

            linea = leer.ReadLine();

            for (int i = 0; linea != null; i++)
            {
                extensiones[i] = linea;

                linea = leer.ReadLine();
            }

            leer.Close();

        }

    }
}
