using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07.Ficheros.C_.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuArchivos()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(" SELECCIONES UNA OPCION");
            Console.WriteLine(" [0] -> CERRAR APLICACION");
            Console.WriteLine(" [1] -> Empleado.txt");
            Console.WriteLine(" [2] -> Gerencia.txt");
            Console.WriteLine(" [3] -> Apuntes.txt");
            Console.WriteLine("------------------------");

            int seleccionArchios = Convert.ToInt32(Console.ReadLine());
            return seleccionArchios;


        }


        public int menuAcciones()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(" SELECCIONES UNA OPCION");
            Console.WriteLine(" [0] -> CERRAR APLICACION");
            Console.WriteLine(" [1] -> MODIFICACION");
            Console.WriteLine(" [2] -> INSERCION");
            Console.WriteLine("------------------------");
            int seleccionAcciones = Convert.ToInt32(Console.ReadLine());
            return seleccionAcciones;

        }



    }
}
