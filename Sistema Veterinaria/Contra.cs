using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Npgsql;

namespace Sistema_Veterinaria
{
    public partial class Contra : Form
    {

        NpgsqlConnection conn = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");

        public Contra()
        {
            InitializeComponent();
            textBox1.Text = Global.getid().ToString();
            ConsultarUyC();
        }

        public void ConsultarUyC()
        {
            conn.Open();
            string query = "select usuario, contrasena from empleado where id_empleado = '" + Global.getid() + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            reader.Read();
            textBox2.Text = reader.GetString(0);
            ID.Text = reader.GetString(1);
            conn.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //insertar datos en tabla empleado
            try
            {
                conn.Open();

                string query = "UPDATE empleado SET contrasena='" + Detalles.Text + "' WHERE id_empleado='" + Global.getid() + "'";

                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                conector.ExecuteNonQuery();
                MessageBox.Show("Contraseña actualizada.");
                conn.Close();
            }
            catch (Exception a)
            {
                conn.Close();
            }

            ConsultarUyC();
        }
    }
}
