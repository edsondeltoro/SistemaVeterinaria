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
    public partial class Producto : Form
    {
        private bool validado = true;
        private int id;
        private string nombre;
        private decimal precio;
        private decimal precio_venta;
        private int cantidad;
        private string detalles;
        private bool estado;
        private bool mod = false;

        Validar Validar = new Validar();

        NpgsqlConnection conn = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");

        public Producto()
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
        public bool validaEstado(string txt)
        {
            if (txt == "Activo")
                estado = true;
            else if (txt == "Inactivo")
                estado = false;
            else
            {
                MessageBox.Show("Estado: (" + Estado.Text + ") inválido, por favor eliga un estado válido (Activo o Inactivo)");
                Estado.Text = null;
                return false;
            }
            return true;
        }

        public DataTable Consultar()
        {
            string query = "select id_producto, nombre, cantidad, precio_venta, precio, detalles, estado from producto where estado = 'true'";
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

        private void Nuevo_Click(object sender, EventArgs e)
        {
            conn.Open();
            mod = false;
            string query = "select id_producto from producto";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();

            int max = 0;

            while (reader.Read())
            {
                if (reader.GetInt32(0) > max)
                    max = reader.GetInt32(0);
            }
            max++;
            ID.Text = max.ToString();

            Nombre.Text = "";
            Precio.Text = "";
            Precio_venta.Text = "";
            Cantidad.Text = "0";
            Detalles.Text = "";
            Estado.Text = "";

            Nombre.Enabled = true;
            Precio.Enabled = true;
            Precio_venta.Enabled = true;
            Detalles.Enabled = true;
            Estado.Enabled = true;
            Modificar.Enabled = false;
            conn.Close();
        }

        private void Guardar_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            validado = true;
            nombre = Nombre.Text;
            detalles = Detalles.Text;
            cantidad = int.Parse(Cantidad.Text);
            estado = true;

            if (!Validar.Llenado(ID.Text, "c"))
                validado = false;
            else
                id = int.Parse(ID.Text);

            if (!Validar.Llenado(nombre, "Nombre de producto"))
                validado = false;

            if (!Validar.Llenado(Precio.Text, "Precio de compra"))
                validado = false;
            else
            {
                try
                {
                    precio = Convert.ToDecimal(Precio.Text);
                    if (precio < 0)
                    {
                        MessageBox.Show("Favor de no ingresar números negativos el campo precio de compra.");
                        validado = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor de ingresar solo números y puntos decimales en el campo precio de compra.");
                    validado = false;
                }
            }

            if (!Validar.Llenado(Precio_venta.Text, "Precio de venta"))
                validado = false;
            else
            {
                try
                {
                    precio_venta = Convert.ToDecimal(Precio_venta.Text);
                    if (precio_venta < 0)
                    {
                        MessageBox.Show("Favor de no ingresar números negativos el campo precio de venta.");
                        validado = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor de ingresar solo números y puntos decimales en el campo precio de venta.");
                    validado = false;
                }
            }

            if (!Validar.Llenado(Estado.Text, "Estado"))
                validado = false;
            else if (!validaEstado(Estado.Text))
                validado = false;

            if (validado)
            {
                string sql = null;
                if (!mod)
                {
                    sql = "INSERT INTO producto (id_producto, nombre, precio, precio_venta, cantidad, detalles, estado) VALUES ('" + id + "','" + nombre + "','" + precio + "','" + precio_venta + "','" +
                    cantidad + "','" + detalles + "','" + estado + "')";
                }
                else if (mod)
                {
                    sql = "UPDATE producto SET id_producto='" + id + "', nombre='" + nombre + "', precio='" + precio + "', precio_venta='" + precio_venta + "', cantidad='" + cantidad + "', detalles='" + detalles + "', " +
                        "estado='" + estado + "' WHERE id_producto='" + id + "'";
                    mod = false;
                }

                try
                {
                    NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado.");
                    ID.Text = "";
                    Nombre.Text = "";
                    Precio.Text = "";
                    Precio_venta.Text = "";
                    Detalles.Text = "";
                    Estado.Text = "";
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
            if (Buscar.Text == "")
                dataGridView1.DataSource = Consultar();
            else
                dataGridView1.DataSource = Consultar(Buscar.Text);
            conn.Close();
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
            Modificar.Enabled = true;
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Buscar.Text == "")
                dataGridView1.DataSource = Consultar();
            else
                dataGridView1.DataSource = Consultar(Buscar.Text);
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Nombre.Enabled = true;
            Precio.Enabled = true;
            Precio_venta.Enabled = true;
            Detalles.Enabled = true;
            Estado.Enabled = true;
            Modificar.Enabled = false;
            mod = true;
        }

        private void Precio_venta_TextChanged(object sender, EventArgs e)
        {
            if (Precio_venta.Text.Any(char.IsLetter) || Precio_venta.Text.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("Favor de ingresar solo números o puntos decimales.");
                Precio_venta.Text = null;
            }
        }
    }
}
