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
    public partial class RegistrarVentaM : Form
    {
        private string fecha = DateTime.Now.ToString();
        private string nombre;
        private decimal precio;
        private string detalles;
        private bool ban1 = false;
        private bool ban2 = false;

        Validar Validar = new Validar();

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = Frijolito4819.; Database = veterinaria4");

        public RegistrarVentaM()
        {
            InitializeComponent();
            conn.Open();
            dataGridView1.DataSource = Consultar_producto();
            dataGridView3.DataSource = Consultar_proveedor();
            Fecha.Text = fecha;
            string query = "select id_venta from venta";
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
            ID_empleado.Text = Global.getid().ToString();
            conn.Close();
            Advertencia();
            DataTable dt = ConsultarTelefonos();
            ElegirTelefono.DataSource = dt;
            ElegirTelefono.ValueMember = "telefono";
            DataTable dt2 = ConsultarDuenos();
            ElegirDueno.DataSource = dt2;
            ElegirDueno.ValueMember = "nombre_dueno";
        }
        public DataTable ConsultarTelefonos()
        {
            string query = "select telefono from mascota";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ConsultarDuenos()
        {
            string query = "select nombre_dueno from mascota";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
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
            string query = "select id_mascota, nombre, nombre_dueno, telefono from mascota where estado = true";
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
                    string query = "select id_mascota, nombre, nombre_dueno, telefono from mascota where id_mascota = '" + txt + "' AND nombre_dueno != 'Cualquiera' AND estado = 'true'";
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
                    string query = "select id_mascota, nombre, nombre_dueno, telefono from mascota where nombre = '" + txt + "' AND nombre_dueno != 'Cualquiera' AND estado = 'true'";
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

        public DataTable ConsultaDueno(string txt)
        {
            try
            {
                string query = "select id_mascota, nombre, nombre_dueno, telefono from mascota where nombre_dueno = '" + txt + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);

                return tabla;
            }
            catch (NpgsqlException)
            {
            }

            return null;
        }
        public DataTable ConsultaTelefono(string txt)
        {
            try
            {
                string query = "select id_mascota, nombre, nombre_dueno, telefono from mascota where telefono = '" + txt + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);

                return tabla;
            }
            catch (NpgsqlException)
            {
            }

            return null;
        }

        public DataTable ConsultaAmbos(string txt, string txt2)
        {

            try
            {
                string query = "select id_mascota, nombre, nombre_dueno, telefono from mascota where nombre_dueno = '" + txt + "' AND telefono = '" + txt2 + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);

                return tabla;
            }
            catch (NpgsqlException)
            {
            }

            return null;
        }

        public void Eliminar()
        {
            dataGridView2.Rows.Clear();
        }

        public void Actualizar_total()
        {
            if (dataGridView2.RowCount > 0)
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

        private void Buscar_cliente_TextChanged(object sender, EventArgs e)
        {
            if (Buscar_cliente.Text == "")
                dataGridView3.DataSource = Consultar_proveedor();
            else
                dataGridView3.DataSource = Consultar_proveedor(Buscar_cliente.Text);
        }

        private void Vaciar_Click_1(object sender, EventArgs e)
        {
            ID_Proveedor.Text = null;
            Eliminar();
            Actualizar_total();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            string id = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
            string query = "select id_producto, nombre, detalles, precio_venta from producto where id_producto= '" + id + "'";
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

        private void Buscar_TextChanged_1(object sender, EventArgs e)
        {
            if (Buscar.Text == "")
                dataGridView1.DataSource = Consultar_producto();
            else
                dataGridView1.DataSource = Consultar_producto(Buscar.Text);
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
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

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            string id = Convert.ToString(dataGridView3.SelectedRows[0].Cells[0].Value);
            string query = "select id_mascota from mascota where id_mascota= '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            reader.Read();
            ID_Proveedor.Text = reader.GetInt32(0).ToString();
            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool validado = true;
            decimal x = 0;
            if (Validar.Llenado(ID_Producto.Text, "d"))
            {
                if (numericUpDown1.Value > 0)
                {
                    for (int y = 0; y < dataGridView1.RowCount; y++)
                    {
                        if (Convert.ToString(dataGridView1.Rows[y].Cells[0].Value) == ID_Producto.Text)
                        {
                            x += Convert.ToDecimal(dataGridView1.Rows[y].Cells[2].Value);
                            break;
                        }
                    }
                    for (int y = 0; y < dataGridView2.RowCount; y++)
                    {
                        if (Convert.ToString(dataGridView2.Rows[y].Cells[0].Value) == ID_Producto.Text)
                        {
                            x -= Convert.ToDecimal(dataGridView2.Rows[y].Cells[3].Value);
                            break;
                        }
                    }
                    if (numericUpDown1.Value <= x)
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
                        MessageBox.Show("Cantidad elegida mayor a la que hay en stock.");

                }
                else
                    MessageBox.Show("Favor de seleccionar una cantidad a agregar.");
            }
        }

        private void Precio_producto_TextChanged_1(object sender, EventArgs e)
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
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void Guardar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
            {
                //Venta
                string sql;
                int id_venta = int.Parse(ID.Text);
                int cant;
                int mascota;

                if (ID_Proveedor.Text != "")
                    mascota = int.Parse(ID_Proveedor.Text);
                else
                    mascota = 0;

                string empleado = ID_empleado.Text;
                string fecha = DateTime.Parse(Fecha.Text).ToString("yyyy-MM-dd");

                conn.Open();
                string query = "select id_iva from iva where estado= 'true'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                reader.Read();
                int iva = reader.GetInt32(0);
                conn.Close();

                if (mascota == 0)
                {
                    conn.Open();
                    sql = "INSERT INTO venta (id_venta, fecha, id_iva, id_empleado) VALUES ('" + id_venta + "','" + fecha + "','" + iva + "','" + empleado + "')";
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
                }
                else
                {
                    conn.Open();
                    sql = "INSERT INTO venta (id_venta, id_mascota, fecha, id_iva, id_empleado) VALUES ('" + id_venta + "','" + mascota + "','" + fecha + "','" + iva + "','" + empleado + "')";
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
                }

                //Detalle de compra

                conn.Open();
                query = "select id_detalle_venta from detalle_venta";
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

                for (int y = 0; y < dataGridView2.RowCount; y++)
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
                    cant -= cantidad;
                    conn.Close();

                    conn.Open();
                    query = "UPDATE producto SET cantidad='" + cant + "' where id_producto = '" + producto + "'";
                    NpgsqlCommand comando4 = new NpgsqlCommand(query, conn);
                    comando4.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    sql = "INSERT INTO detalle_venta (id_detalle_venta, id_venta, id_producto, cantidad, precio) VALUES ('" + id_detalle + "','" + id_venta + "','" + producto + "','"
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
                id_venta++;
                ID.Text = id_venta.ToString();
                ID_Producto.Text = "";
                Nombre.Text = "";
                Descripcion.Text = "";
                Precio_producto.Text = "";
                numericUpDown1.Value = 0;
                Importe.Text = "";
                Eliminar();
                Actualizar_total();
                MessageBox.Show("Registro guardado.");
                Advertencia();
            }
        }

        private void ElegirDueno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ban1 = true;
            if (ban2 == true)
            {
                if (ElegirDueno.Text == "Cualquiera" && ElegirTelefono.Text == "Cualquiera")
                    dataGridView3.DataSource = Consultar_proveedor();
                else if (ElegirTelefono.Text == "Cualquiera")
                    dataGridView3.DataSource = ConsultaDueno(ElegirDueno.Text);
                else if (ElegirDueno.Text == "Cualquiera")
                    dataGridView3.DataSource = ConsultaTelefono(ElegirTelefono.Text);
                else
                    dataGridView3.DataSource = ConsultaAmbos(ElegirDueno.Text, ElegirTelefono.Text);
            }
            else if (ElegirDueno.Text == "Cualquiera")
                dataGridView3.DataSource = Consultar_proveedor();
            else
                dataGridView3.DataSource = ConsultaDueno(ElegirDueno.Text);
        }

        private void ElegirTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            ban2 = true;
            if (ban1 == true)
            {
                if (ElegirDueno.Text == "Cualquiera" && ElegirTelefono.Text == "Cualquiera")
                    dataGridView3.DataSource = Consultar_proveedor();
                else if (ElegirTelefono.Text == "Cualquiera")
                    dataGridView3.DataSource = ConsultaDueno(ElegirDueno.Text);
                else if (ElegirDueno.Text == "Cualquiera")
                    dataGridView3.DataSource = ConsultaTelefono(ElegirTelefono.Text);
                else
                    dataGridView3.DataSource = ConsultaAmbos(ElegirDueno.Text, ElegirTelefono.Text);
            }
            else if (ElegirTelefono.Text == "Cualquiera")
                dataGridView3.DataSource = Consultar_proveedor();
            else
                dataGridView3.DataSource = ConsultaTelefono(ElegirTelefono.Text);
        }
    }
}