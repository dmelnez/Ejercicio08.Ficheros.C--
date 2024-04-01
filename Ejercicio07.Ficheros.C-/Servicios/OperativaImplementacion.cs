using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07.Ficheros.C_.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        MenuInterfaz me = new MenuImplementacion();

        public void archivoAcciones(string rutaArchivo)
        {

            int seleccionModificacion = me.menuAcciones();

            bool cerrarAplicacions = false;

            do { 
            
                switch (seleccionModificacion)
                {
                    case 0:
                        // Seleccion de Acceder al Menu Principal
                        cerrarAplicacions = true;
                    break;

                    case 1:

                        // Control de Excepcion de IOException. Con la Finalidad de Evitar, que el error llegue al cliente
                        try
                        { 
                        // Seleccion de Modificacion en un Archivo
                        modificacionArchivos(rutaArchivo);
                        }

                        catch (IOException ex)
                        {
                            Console.WriteLine("[INFO] -> Se ha un Error. Intentelo mas Tarde: " + ex.Message + " " +
                                ex.ToString);
                        }

                        break;

                    case 2:


                        // Control de Excepcion de IOException. Con la Finalidad de Evitar, que el error llegue al cliente
                        try
                        {
                            // Seleccion de Inserccion en la Posicion especifica en un Archivo
                            inserccionArchivo(rutaArchivo);

                        }

                        catch (IOException ex)
                        {
                            Console.WriteLine("[INFO] -> Se ha un Error. Intentelo mas Tarde: " + ex.Message + " " +
                                ex.ToString);
                        }
                        break;


                    default:
                        Console.WriteLine("[INFO] SELECCION NO VALIDA");
                    break;

    
                }

            }

            while (!cerrarAplicacions);


        }


        /// <summary>
        /// Metodo encargado, de mostrar al usuario el contenido del Archivo seleccionado. 
        /// Solicitara el numero de la linea a Modificar, y contenido que contendra una vez Modificado.
        /// </summary>
        /// <author>DMN - 27/03/2024</author>
        /// <param name="rutaArchivo"></param>
        private void modificacionArchivos(string rutaArchivo)
        {
            // Division del Archivo. 
            // Cada una de las lineas contenientes del archivo, es almacenado en una posicion distinta del Array.
            // Las lineas en blanco, siguen siendo acumuladas en las posciones del array.
            string[] archivoDivido = File.ReadAllLines(rutaArchivo);

          
            for (int i = 0; i < archivoDivido.Length -1; i++)
            {
                Console.WriteLine(archivoDivido[i]);

            }

            Console.WriteLine("Linea Modificada: ");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Texto a Sustituir");
            string contenidoSustido = Console.ReadLine();

            archivoDivido[numeroLinea] = contenidoSustido;

            File.WriteAllLines(rutaArchivo, archivoDivido);


        }


        /// <summary>
        /// Metodo encargado, de mostrar al usuario el contenido del Archivo seleccionado. 
        /// Solicitara el numero de la linea a Modificar, y contenido que contendra una vez Modificado.
        /// Solicitara una Posicion Especifica de la Linea.
        /// </summary>
        /// <author>DMN - 27/03/2024</author>
        /// <param name="rutaArchivo"></param>
        private void inserccionArchivo(string rutaArchivo)
        {
            string[] archivoDivido = File.ReadAllLines(rutaArchivo);


            for (int i = 0; i < archivoDivido.Length - 1; i++)
            {
                Console.WriteLine(archivoDivido[i]);

            }

            Console.WriteLine("Linea Modificada: ");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Posicion de la Linea: ");
            int posicionLinea = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Texto a Sustituir");
            string contenidoInsertado = Console.ReadLine();

            string aux = "";

            archivoDivido[numeroLinea] = aux;

            aux.Insert(posicionLinea, contenidoInsertado);

            archivoDivido[numeroLinea] = aux;

            File.WriteAllLines(rutaArchivo, archivoDivido);

        }


    }


}
