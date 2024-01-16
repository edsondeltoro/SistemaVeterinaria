using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Sistema_Veterinaria
{
    public partial class NuevaSesion : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = Frijolito4819.; Database = veterinaria4");
        public NuevaSesion()
        {
            InitializeComponent();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            string name = Usuario.Text;
            string pass = Contrasenna.Text;
            string cont;
            string cargo;
            bool estado;
            string query = "select id_empleado, contrasena, cargo, estado from empleado where usuario = '" + name + "'";
            conn.Open();
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            if (reader.Read())
            {
                Global.setid(reader.GetInt32(0));
                cont = reader.GetString(1);
                cargo = reader.GetString(2);
                estado = reader.GetBoolean(3);
                if (cont == pass)
                {
                    if (estado == true)
                    {
                        if (cargo == "Veterinario")
                        {
                            Form pri = new Veterinario();
                            pri.Show();
                            this.Hide();

                        }
                        else if (cargo == "Mostrador")
                        {
                            Form pri = new Mostrador();
                            pri.Show();
                            this.Hide();

                        }
                        else if (cargo == "Asistente")
                        {
                            Form pri = new Asistente();
                            pri.Show();
                            this.Hide();

                        }
                        else
                            MessageBox.Show("Este usuario no tiene acceso al sistema.");
                    }
                    else
                        MessageBox.Show("Este usuario no está activo.");
                }
                else
                    MessageBox.Show("Usuario o contraseña incorrecto.");
            }
            else
                MessageBox.Show("Usuario o contraseña incorrecto.");
            conn.Close();
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
