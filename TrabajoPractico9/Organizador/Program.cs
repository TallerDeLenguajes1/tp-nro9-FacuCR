using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace Organizador
{
    class Program
    {
        static void Main(string[] args)
        {

            string rutaDelarchivo = @"C:\Users\Facundo\Desktop\Repositorio\tp-nro9-FacuCR\TrabajoPractico9\Organizador\bin\Debug\";

            string[] extensiones = new string[2];

            SoporteParaConfiguracion.CrearArchivoDeConfiguracion();

            SoporteParaConfiguracion.LeerConfiguracion(extensiones);


            foreach (string extension in extensiones)
            {
                MoverArchivos(extension, rutaDelarchivo);
            }

            Console.ReadKey();
        }


            public static void MoverArchivos(string tipoDeExtension, string ruta)
            {

                string destinoDelArchivo = @"C:\Users\Facundo\Desktop\Repositorio\tp-nro9-FacuCR\TrabajoPractico9\Organizador\";

                if (Path.HasExtension(tipoDeExtension))
                {

                    string[] archivos = Directory.GetFiles(ruta);

                    foreach (string archivo in archivos)
                    {
                        if (Path.GetExtension(archivo) == tipoDeExtension)
                            File.Move(archivo, destinoDelArchivo + Path.GetFileName(archivo));
                    }
                }
                else
                    Console.WriteLine(tipoDeExtension + " No es una extension");
            }

    }
}
