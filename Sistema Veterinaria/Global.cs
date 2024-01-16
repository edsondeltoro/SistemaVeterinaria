using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Veterinaria
{
    class Global
    {
        private static int id_empleado;

        public static void setid(int a)
        {
            id_empleado = a;
        }

        public static int getid()
        {
            return id_empleado;
        }
    }
}
