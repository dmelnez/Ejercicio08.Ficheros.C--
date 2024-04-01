using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07.Ficheros.C_.Servicios
{
    internal interface OperativaInterfaz
    {

        /// <summary>
        /// Metodo encargado de Mostrar al Usuario el Menu de Archivos a seleccionar. 
        /// Recogera la seleccion, y lanzara el Programa, a cada una de los metodos encargados de realizar la Operativa.
        /// </summary>
        /// <author>DMN - 27/03/2024</author>
        /// <param name="rutaArchivo"></param>
        public void archivoAcciones(string rutaArchivo);

    }
}
