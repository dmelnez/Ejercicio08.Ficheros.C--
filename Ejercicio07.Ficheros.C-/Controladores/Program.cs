using Ejercicio07.Ficheros.C_.Servicios;

namespace Ejercicio07.Ficheros.C_.Controladores
{
    class Program
    {
        /// <summary>
        /// Metodo por el Cual la Aplicacion se lanzara.
        /// <author>DMN - 27/03/2024</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            
            MenuInterfaz me = new MenuImplementacion();

            OperativaInterfaz op = new OperativaImplementacion();

            bool cerrarAplicacion = false;

            string rutaArchivo;

            do
            {
                int seleccionFicheros = me.menuArchivos();

                try { 

                    switch (seleccionFicheros)
                    {

                        case 0:
                            Console.WriteLine("SE CERRARA LA APLICACION");
                            cerrarAplicacion = true;
                            break;

                        case 1:
                            rutaArchivo = "C:\\Users\\david\\Desktop\\Empleado.txt";
                            op.archivoAcciones(rutaArchivo);

                            break;

                        case 2:
                            rutaArchivo = "C:\\Users\\david\\Desktop\\Gerencia.txt";
                            op.archivoAcciones(rutaArchivo);
                            break;

                        case 3:
                            rutaArchivo = "C:\\Users\\david\\Desktop\\Apuntes.txt";
                            op.archivoAcciones(rutaArchivo);
                            break;

                        default:
                            Console.WriteLine("SELECCION NO VALIDA");
                            break;



                    }
                }

                catch(Exception ex)
                {
                    Console.WriteLine("[INFO] -> Se ha un Error. Intentelo mas Tarde: " + ex.Message + " " + 
                        ex.ToString);                   
                }

            }

            while(!cerrarAplicacion);


        }
    }

}