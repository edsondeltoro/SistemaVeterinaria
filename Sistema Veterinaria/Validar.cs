using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Veterinaria
{
    class Validar
    {

        public bool Llenado(string txt, string campo)
        {
            if (txt == "")
            {
                if (campo == "a")
                    MessageBox.Show("Favor de presionar la opción de (Registrar nuevo proveedor) para agregar un nuevo registro.");
                else if (campo == "b")
                    MessageBox.Show("Favor de presionar la opción de (Registrar nuevo empleado) para agregar un nuevo registro.");
                else if (campo == "c")
                    MessageBox.Show("Favor de presionar la opción de (Registrar nuevo producto) para agregar un nuevo registro.");
                else if (campo == "d")
                    MessageBox.Show("Favor de seleccionar un producto para agregar.");
                else if (campo == "e")
                    MessageBox.Show("Favor de presionar la opción de (Registrar nueva mascota) para agregar un nuevo registro.");
                else if (campo == "z");

                else
                    MessageBox.Show("Favor de llenar el campo faltante (" + campo + ").");

                return false;
            }
            else
                return true;
        }
    }
}
