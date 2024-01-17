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
    public partial class RegistrarCompra : Form
    {
        private string fecha = DateTime.Now.ToString();
        private string nombre;
        private decimal precio;
        private string detalles;

        Validar Validar = new Validar();

        NpgsqlConnection conn = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");

        public RegistrarCompra()
        {
            InitializeComponent();
            conn.Open();
            dataGridView1.DataSource = Consultar_producto();
            dataGridView3.DataSource = Consultar_proveedor();
            Fecha.Text = fecha;
            string query = "select id_compra from compra";
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
            conn.Close();
        }

        public DataTable Consultar_producto()
        {
            string query = "select id_producto, nombre, cantidad, precio_venta from producto where estado = true";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable Consultar_producto(string txt)
        {
            if (txt.All(char.IsDigit))
            {
                try
                {
                    string query = "select id_producto, nombre, cantidad, precio_venta from producto where id_producto = '" + txt + "' AND estado = 'true'";
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
                    string query = "select id_producto, nombre, cantidad, precio_venta from producto where nombre = '" + txt + "' AND estado = 'true'";
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

        public DataTable Consultar_proveedor()
        {
            string query = "select id_proveedor, nombre, telefono from proveedor where estado = true AND nombre != 'Cualquiera'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable Consultar_proveedor(string txt)
        {
            if (txt.All(char.IsDigit))
            {
                try
                {
                    string query = "select id_proveedor, nombre, telefono from proveedor where id_proveedor = '" + txt + "' AND nombre != 'Cualquiera' AND estado = 'true'";
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
                    string query = "select id_proveedor, nombre, telefono from proveedor where nombre = '" + txt + "' AND nombre != 'Cualquiera' AND estado = 'true'";
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

        private void Vaciar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Actualizar_total();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            string id = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
            string query = "select id_producto, nombre, detalles, precio from producto where id_producto= '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            while (reader.Read())
            {
                nombre = reader.GetString(1);
                detalles = reader.GetString(2);
                precio = reader.GetDecimal(3);
            }
            conn.Close();

            numericUpDown1.Value = 1;
            ID_Producto.Text = id;
            Nombre.Text = nombre;
            Descripcion.Text = detalles;
            Precio_producto.Text = precio.ToString();
            decimal x = decimal.Parse(Precio_producto.Text) * numericUpDown1.Value;
            Importe.Text = x.ToString();
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Buscar.Text == "")
                dataGridView1.DataSource = Consultar_producto();
            else
                dataGridView1.DataSource = Consultar_producto(Buscar.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                dataGridView3.DataSource = Consultar_proveedor();
            else
                dataGridView3.DataSource = Consultar_proveedor(textBox1.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

          if (numericUpDown1.Value > 0)
          {
                if(Precio_producto.Text != "")
                {
                    try
                    {
                        decimal x = decimal.Parse(Precio_producto.Text) * numericUpDown1.Value;
                        Importe.Text = x.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Favor de ingresar solo números o puntos decimales.");
                        Precio_producto.Text = "";
                        Importe.Text = "0";
                    }
                }
          }
          else
                Importe.Text = "0";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            string id = Convert.ToString(dataGridView3.SelectedRows[0].Cells[0].Value);
            string query = "select id_proveedor from proveedor where id_proveedor= '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            reader.Read();
            ID_Proveedor.Text = reader.GetInt32(0).ToString();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validado = true;
            if (Validar.Llenado(ID_Producto.Text, "d"))
            {
                if (numericUpDown1.Value > 0)
                {
                    if (!Validar.Llenado(Precio_producto.Text, "Precio de producto"))
                        validado = false;
                    else
                    {
                        try
                        {
                            precio = decimal.Parse(Precio_producto.Text);
                            if (precio < 0)
                            {
                                MessageBox.Show("Favor de no ingresar números negativos el campo Precio de producto.");
                                validado = false;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Favor de ingresar solo números y puntos decimales en el campo Precio de producto.");
                            validado = false;
                        }
                    }
                    bool ban = true;

                    if (validado)
                    {

                        for (int y = 0; y < dataGridView2.RowCount; y++)
                        {
                            if (Convert.ToString(dataGridView2.Rows[y].Cells[0].Value) == ID_Producto.Text)
                            {
                                dataGridView2.Rows[y].Cells[3].Value = Convert.ToDecimal(dataGridView2.Rows[y].Cells[3].Value) + numericUpDown1.Value;
                                dataGridView2.Rows[y].Cells[4].Value = Convert.ToDecimal(dataGridView2.Rows[y].Cells[3].Value) * Convert.ToDecimal(dataGridView2.Rows[y].Cells[2].Value);
                                ban = false;
                                break;
                            }
                        }

                        if (ban)
                            dataGridView2.Rows.Insert(dataGridView2.RowCount, ID_Producto.Text, Nombre.Text, Precio_producto.Text, numericUpDown1.Value.ToString(), Importe.Text);

                        ID_Producto.Text = "";
                        Nombre.Text = "";
                        Descripcion.Text = "";
                        Precio_producto.Text = "";
                        numericUpDown1.Value = 0;
                        Importe.Text = "";
                        Actualizar_total();
                    }
                }
                else
                    MessageBox.Show("Favor de seleccionar una cantidad a agregar.");
            }
        }

        private void Precio_producto_TextChanged(object sender, EventArgs e)
        {
            if (Precio_producto.Text.Any(char.IsLetter) || Precio_producto.Text.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("Favor de ingresar solo números o puntos decimales.");
                Precio_producto.Text = null;
            }
            else
            {
                if (numericUpDown1.Value > 0)
                {
                    if (Precio_producto.Text != "")
                    {
                        try
                        {
                            decimal x = decimal.Parse(Precio_producto.Text) * numericUpDown1.Value;
                            Importe.Text = x.ToString();
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Favor de ingresar solo números o puntos decimales.");
                            Precio_producto.Text = "";
                            Importe.Text = "0";
                        }
                    }
                }
                else
                    Importe.Text = "0";
            }
        }

        public void Eliminar()
        {
            dataGridView2.Rows.Clear();
        }

        public void Actualizar_total()
        {
            if(dataGridView2.RowCount > 0)
            {
                double subtotal = 0;
                double iva;
                double iva_t;
                double total;

                for (int y = 0; y < dataGridView2.RowCount; y++)
                {
                    subtotal += Convert.ToDouble(dataGridView2.Rows[y].Cells[4].Value);
                }

                conn.Open();
                string query = "select porcentaje from iva where estado= 'true'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                reader.Read();
                iva = reader.GetDouble(0);
                conn.Close();

                iva_t = subtotal * iva;
                total = subtotal + iva_t;

                Subtotal.Text = subtotal.ToString();
                IVA.Text = iva_t.ToString();
                Total.Text = total.ToString();
            }
            else
            {
                Subtotal.Text = "";
                IVA.Text = "";
                Total.Text = "";
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            string id = Convert.ToString(dataGridView2.SelectedRows[0].Cells[0].Value);
            string cant = Convert.ToString(dataGridView2.SelectedRows[0].Cells[3].Value);
            string query = "select id_producto, nombre, detalles, precio from producto where id_producto= '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            while (reader.Read())
            {
                nombre = reader.GetString(1);
                detalles = reader.GetString(2);
                precio = reader.GetDecimal(3);
            }
            conn.Close();

            numericUpDown1.Value = decimal.Parse(cant);
            ID_Producto.Text = id;
            Nombre.Text = nombre;
            Descripcion.Text = detalles;
            Precio_producto.Text = precio.ToString();
            decimal x = decimal.Parse(Precio_producto.Text) * numericUpDown1.Value;
            Importe.Text = x.ToString();

            dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);

            Actualizar_total();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if(dataGridView2.RowCount > 0)
            {
                if(ID_Proveedor.Text != "")
                {
                    //Compra
                    string sql;
                    int id_compra = int.Parse(ID.Text);
                    int cant;
                    string proveedor = ID_Proveedor.Text;
                    string fecha = DateTime.Parse(Fecha.Text).ToString("yyyy-MM-dd");

                    conn.Open();
                    string query = "select id_iva from iva where estado= 'true'";
                    NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader reader = conector.ExecuteReader();
                    reader.Read();
                    int iva = reader.GetInt32(0);
                    conn.Close();

                    conn.Open();
                    sql = "INSERT INTO compra (id_compra, id_proveedor, fecha, id_iva) VALUES ('" + id_compra + "','" + proveedor + "','" + fecha + "','" + iva + "')";
                    try
                    {
                        NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
                        comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                    conn.Close();

                    //Detalle de compra

                    conn.Open();
                    query = "select id_detalle_compra from detalle_compra";
                    NpgsqlCommand conector2 = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader reader2 = conector2.ExecuteReader();

                    int max = 0;
                    while (reader2.Read())
                    {
                        if (reader2.GetInt32(0) > max)
                            max = reader2.GetInt32(0);
                    }
                    max++;
                    int id_detalle = max;
                    int producto;
                    int cantidad;
                    decimal precio;

                    conn.Close();

                    for(int y = 0; y < dataGridView2.RowCount; y++)
                    {
                        producto = Convert.ToInt32(dataGridView2.Rows[y].Cells[0].Value);
                        cantidad = Convert.ToInt32(dataGridView2.Rows[y].Cells[3].Value);
                        precio = Convert.ToDecimal(dataGridView2.Rows[y].Cells[2].Value);

                        conn.Open();
                        query = "select cantidad from producto where id_producto= '" + producto + "'";
                        NpgsqlCommand conector3 = new NpgsqlCommand(query, conn);
                        NpgsqlDataReader reader3 = conector3.ExecuteReader();
                        reader3.Read();
                        cant = reader3.GetInt32(0);
                        cant += cantidad;
                        conn.Close();

                        conn.Open();
                        query = "UPDATE producto SET cantidad='" + cant + "' where id_producto = '" + producto + "'";
                        NpgsqlCommand comando4 = new NpgsqlCommand(query, conn);
                        comando4.ExecuteNonQuery();
                        conn.Close();

                        conn.Open();
                        sql = "INSERT INTO detalle_compra (id_detalle_compra, id_compra, id_producto, cantidad, precio) VALUES ('" + id_detalle + "','" + id_compra + "','" + producto + "','"
                            + cantidad + "','" + precio + "')";
                        try
                        {
                            NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
                            comando.ExecuteNonQuery();
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show("Error al guardar: " + ex.Message);
                        }
                        conn.Close();
                        id_detalle++;
                    }

                    //Limpieza
                    dataGridView1.DataSource = Consultar_producto();
                    id_compra++;
                    ID.Text = id_compra.ToString();
                    ID_Producto.Text = "";
                    Nombre.Text = "";
                    Descripcion.Text = "";
                    Precio_producto.Text = "";
                    numericUpDown1.Value = 0;
                    Importe.Text = "";
                    Eliminar();
                    Actualizar_total();
                    MessageBox.Show("Registro guardado.");

                }

                else
                    MessageBox.Show("Favor de seleccionar un proveedor.");
            }
        }
    }
}
