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
    public partial class Asistencia_cs : Form
    {
        public Asistencia_cs()
        {
            InitializeComponent();
            id_empleado.Text = Global.getid().ToString();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = Frijolito4819.; Database = veterinaria4");

        private void button1_Click(object sender, EventArgs e)
        {
            string id_emp = id_empleado.Text;
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            string Time = DateTime.Now.ToString("HH:mm:ss");

            string sql = "insert into asistencia_entrada (idempleado, fecha, hora)  values ('" + id_emp + "','" + Date + "','" + Time + "')";
            conn.Open();
            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
                comando.ExecuteNonQuery();
                label2.Text = "Entrada registrada: " + Date + " " + Time;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id_emp = id_empleado.Text;
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            string Time = DateTime.Now.ToString("HH:mm:ss");
            TimeSpan HoraE;
            double ganado = 0;
            bool ban = false;

            conn.Open();
            string sql = "select sueldo from empleado where id_empleado = '" + id_emp + "'";
            NpgsqlCommand conector = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            reader.Read();
            double sueldo = reader.GetInt32(0);
            conn.Close();

            conn.Open();
            sql = "select hora from asistencia_entrada where fecha = '" + Date + "' AND idempleado = '" + id_emp + "'";
            conector = new NpgsqlCommand(sql, conn);
            reader = conector.ExecuteReader();
            if (reader.Read())
            {
                ban = true;
                HoraE = reader.GetTimeSpan(0);
                ganado = (DateTime.Now.Hour - HoraE.Hours) * sueldo;
            }
            conn.Close();

            if (ban)
            {
                sql = "insert into asistencia_salida (idempleado, fecha, hora, sueldo)  values ('" + id_emp + "','" + Date + "','" + Time + "','" + ganado + "')";
                conn.Open();
                try
                {
                    NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
                    comando.ExecuteNonQuery();
                    label3.Text = "Salida registrada: " + Date + " " + Time;
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                conn.Close();
            }

            else
                MessageBox.Show("Todavía no se registra una entrada hoy.");
        }
    }
}
