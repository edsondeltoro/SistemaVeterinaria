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
    public partial class Ganancias : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = Frijolito4819.; Database = veterinaria4");
        NpgsqlConnection conn2 = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = Frijolito4819.; Database = veterinaria4");

        public Ganancias()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string F_ini = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");
            string F_fin = DateTime.Parse(dateTimePicker2.Text).ToString("yyyy-MM-dd");
            double ventas;
            double citas = 0;
            double compras;
            double precioproducto;
            double cantidad;
            double empleados = 0;

            //string query1 = "select SUM (precio) AS total from citas where fecha >= '"+ F_ini +"' AND fecha <=  '"+ F_fin + "' AND estado = '" + true + "'";

            string query02 = "select id_venta from venta where fecha >= '" + F_ini + "' AND fecha <=  '" + F_fin + "'";

            string query3 = "select SUM(sueldo) from asistencia_salida where fecha >= '" + F_ini + "' AND fecha <=  '" + F_fin + "'";

            string query04 = "select id_compra from compra where fecha >= '" + F_ini + "' AND fecha <=  '" + F_fin + "'";

            string query1 = "select SUM (precio) AS total from citas where fecha >= '" + F_ini + "' AND fecha <=  '" + F_fin + "' AND estado = '" + true + "'";

            try { 
                conn.Open();
                NpgsqlCommand conector1 = new NpgsqlCommand(query1, conn);
                NpgsqlDataReader datos1 = conector1.ExecuteReader();
                datos1.Read();
                citas = datos1.GetInt32(0);
                conn.Close();
            }
            catch (Exception ex) {
                conn.Close();
            }

            conn2.Open();
            ventas = 0;
            NpgsqlCommand conector02 = new NpgsqlCommand(query02, conn2);
            NpgsqlDataReader datos02 = conector02.ExecuteReader();
            while (datos02.Read()) {
                string query2 = "select precio, cantidad from detalle_venta where id_venta = '" + datos02.GetInt32(0) + "'";
                conn.Open();
                NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn);
                NpgsqlDataReader datos2 = conector2.ExecuteReader();
                while (datos2.Read())
                {
                    precioproducto = datos2.GetDouble(0);
                    cantidad = datos2.GetInt32(1);
                    ventas += precioproducto * cantidad;
                }
                conn.Close();
            }
            conn2.Close();

            try { 
                conn.Open();
                NpgsqlCommand conector3 = new NpgsqlCommand(query3, conn);
                NpgsqlDataReader datos3 = conector3.ExecuteReader();
                datos3.Read();
                empleados = datos3.GetInt32(0);
                conn.Close();
            }
            catch (Exception ex) {
                conn.Close();
            }

            conn2.Open();
            compras = 0;
            NpgsqlCommand conector04 = new NpgsqlCommand(query04, conn2);
            NpgsqlDataReader datos04 = conector04.ExecuteReader();
            while (datos04.Read())
            {
                string query4 = "select precio, cantidad from detalle_compra where id_compra = '" + datos04.GetInt32(0) + "'";
                conn.Open();
                NpgsqlCommand conector4 = new NpgsqlCommand(query4, conn);
                NpgsqlDataReader datos4 = conector4.ExecuteReader();
                while (datos4.Read()) { 
                    precioproducto = datos4.GetDouble(0);
                    cantidad = datos4.GetInt32(1);
                    compras += precioproducto * cantidad;
                }
            conn.Close();
            }
            conn2.Close();


            double salidas = empleados + compras;
            double entradas = citas + ventas;

            dataGridView1.Rows.Insert(0, citas, ventas, empleados, compras);

            double ganacias = entradas - salidas;
            if(ganacias > 0)
            {
                label3.Text = "Ganancia de: " + ganacias;
            }
            else
                label3.Text = "Pérdida de: " + ganacias;

        }
    }
}
