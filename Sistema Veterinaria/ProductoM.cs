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
    public partial class ProductoM : Form
    {
        Validar Validar = new Validar();

        NpgsqlConnection conn = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");

        public ProductoM()
        {
            InitializeComponent();
            conn.Open();
            dataGridView1.DataSource = Consultar();
            conn.Close();
            Advertencia();
        }

        public void Advertencia()
        {
            string nombre;
            int cantidad;
            conn.Open();
            try
            {
                string query = "select nombre, cantidad from producto where estado = true";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    nombre = reader.GetString(0);
                    cantidad = reader.GetInt32(1);
                    if (cantidad > 1 && cantidad < 6)
                    {
                        MessageBox.Show("Solo quedan " + cantidad + " " + nombre);
                    }
                    else if (cantidad == 1)
                    {
                        MessageBox.Show("Solo queda " + cantidad + " " + nombre);
                    }
                    else if (cantidad == 0)
                    {
                        MessageBox.Show("Ya no quedan " + nombre);
                    }
                }
            }
            catch
            {

            }
            conn.Close();
        }

        public DataTable Consultar()
        {
            string query = "select id_producto, nombre, cantidad, precio_venta, precio, detalles, estado from producto where estado = true";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable Consultar(string txt)
        {
            if (txt.All(char.IsDigit))
            {
                try
                {
                    string query = "select id_producto, nombre, cantidad, precio_venta, precio, detalles, estado from producto where id_producto = '" + txt + "'";
                    NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                    NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);

                    return tabla;
                }
                catch (NpgsqlException)
                {
                }
            }
            else
            {
                try
                {
                    string query = "select id_producto, nombre, cantidad, precio_venta, precio, detalles, estado from producto where nombre = '" + txt + "'";
                    NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                    NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);

                    return tabla;
                }
                catch (NpgsqlException)
                {
                }
            }
            return null;
        }

        private void Precio_TextChanged(object sender, EventArgs e)
        {
            if (Precio.Text.Any(char.IsLetter) || Precio.Text.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("Favor de ingresar solo números o puntos decimales.");
                Precio.Text = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
            string nombre = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            string cantidad = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            string precio_venta = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
            string precio = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value);
            string detalles = Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value);
            string estado = Convert.ToString(dataGridView1.SelectedRows[0].Cells[6].Value);

            ID.Text = id;
            Nombre.Text = nombre;
            Precio.Text = precio;
            Precio_venta.Text = precio_venta;
            Cantidad.Text = cantidad;
            Detalles.Text = detalles;

            if (estado == "True")
                Estado.Text = "Activo";
            else if (estado == "False")
                Estado.Text = "Inactivo";

            Nombre.Enabled = false;
            Precio.Enabled = false;
            Precio_venta.Enabled = false;
            Detalles.Enabled = false;
            Estado.Enabled = false;
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Buscar.Text == "")
                dataGridView1.DataSource = Consultar();
            else
                dataGridView1.DataSource = Consultar(Buscar.Text);
        }

        private void Precio_venta_TextChanged(object sender, EventArgs e)
        {
            if (Precio_venta.Text.Any(char.IsLetter) || Precio_venta.Text.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("Favor de ingresar solo números o puntos decimales.");
                Precio_venta.Text = null;
            }
        }

        private void Detalles_TextChanged(object sender, EventArgs e)
        {

        }

        private void Estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
