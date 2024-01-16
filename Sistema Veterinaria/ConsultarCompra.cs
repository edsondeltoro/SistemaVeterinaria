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
    public partial class ConsultarCompra : Form
    {
        Validar Validar = new Validar();

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = Frijolito4819.; Database = veterinaria4");
        NpgsqlConnection conn2 = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = Frijolito4819.; Database = veterinaria4");

        private bool ban1 = false;
        private bool ban2 = false;
        private bool fecha = true;

        public ConsultarCompra()
        {
            InitializeComponent();
            ConsultarC();
            DataTable dt = ConsultarProveedores();
            ElegirProveedor.DataSource = dt;
            ElegirProveedor.ValueMember = "nombre";
        }

        public DataTable ConsultarProveedores()
        {
            string query = "select nombre from proveedor";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void ConsultarC()
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            string id;
            string fecha;
            string nombre;
            conn.Open();
            string query = "select id_compra, id_proveedor, fecha from compra";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
                string query2 = "select nombre from proveedor where id_proveedor = '" + reader.GetInt32(1) + "'";
                conn2.Open();
                NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                NpgsqlDataReader reader2 = conector2.ExecuteReader();
                reader2.Read();
                nombre = reader2.GetString(0);
                conn2.Close();
                fecha = reader.GetDate(2).ToString();
                dataGridView1.Rows.Insert(i, id, nombre, fecha);
                i++;
            }
            conn.Close();
        }

        public void ConsultarC(int txt)
        {
            for (int y = 0; y < dataGridView1.RowCount; y++)
            {
                try
                {
                    if (txt == Convert.ToInt32(dataGridView1.Rows[y].Cells[0].Value))
                    {
                        dataGridView1.Rows.Clear();
                        int i = 0;
                        string id;
                        string fecha;
                        string nombre;
                        conn.Open();
                        string query = "select id_compra, id_proveedor, fecha from compra where id_compra= '" + txt + "'";
                        NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                        NpgsqlDataReader reader = conector.ExecuteReader();
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0).ToString();
                            fecha = reader.GetDate(2).ToString();
                            string query2 = "select nombre from proveedor where id_proveedor = '" + reader.GetInt32(1) + "'";
                            conn2.Open();
                            NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                            NpgsqlDataReader reader2 = conector2.ExecuteReader();
                            reader2.Read();
                            nombre = reader2.GetString(0);
                            conn2.Close();
                            dataGridView1.Rows.Insert(i, id, nombre, fecha);
                            i++;
                        }

                        conn.Close();
                        break;
                    }
                }
                catch (Exception)
                {

                }
            }
        }


        public void ConsultarP(string txt)
        {
            string id;
            string producto;
            string cantidad;
            string precio;
            string importe;
            for (int y = 0; y < dataGridView2.RowCount; y++)
            {
                try
                {
                    if (txt == Convert.ToString(dataGridView2.Rows[y].Cells[0].Value))
                    {
                        id = Convert.ToString(dataGridView2.Rows[y].Cells[0].Value);
                        producto = Convert.ToString(dataGridView2.Rows[y].Cells[1].Value);
                        cantidad = Convert.ToString(dataGridView2.Rows[y].Cells[2].Value);
                        precio = Convert.ToString(dataGridView2.Rows[y].Cells[3].Value);
                        importe = Convert.ToString(dataGridView2.Rows[y].Cells[4].Value);
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Insert(0, id, producto, cantidad, precio, importe);
                        break;
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        public void ConsultarN(string txt)
        {
            string id;
            string producto;
            string cantidad;
            string precio;
            string importe;
            for (int y = 0; y < dataGridView2.RowCount; y++)
            {
                try
                {
                    if (txt == Convert.ToString(dataGridView2.Rows[y].Cells[1].Value))
                    {
                        id = Convert.ToString(dataGridView2.Rows[y].Cells[0].Value);
                        producto = Convert.ToString(dataGridView2.Rows[y].Cells[1].Value);
                        cantidad = Convert.ToString(dataGridView2.Rows[y].Cells[2].Value);
                        precio = Convert.ToString(dataGridView2.Rows[y].Cells[3].Value);
                        importe = Convert.ToString(dataGridView2.Rows[y].Cells[4].Value);
                        dataGridView2.Rows.Clear();
                        dataGridView2.Rows.Insert(0, id, producto, cantidad, precio, importe);
                        break;
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        public void ConsultarD(int txt)
        {
            dataGridView2.Rows.Clear();
            int i = 0;
            int id;
            double precio;
            double importe;
            int cantidad;
            string nombre;
            conn.Open();
            string query = "select id_producto, cantidad, precio from detalle_compra where id_compra= '" + txt + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
                cantidad = reader.GetInt32(1);
                precio = reader.GetDouble(2);
                string query2 = "select nombre from producto where id_producto = '" + reader.GetInt32(0) + "'";
                conn2.Open();
                NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                NpgsqlDataReader reader2 = conector2.ExecuteReader();
                reader2.Read();
                nombre = reader2.GetString(0);
                conn2.Close();
                importe = precio * cantidad;
                dataGridView2.Rows.Insert(i, id, nombre, cantidad, precio, importe);
                i++;
            }
            conn.Close();
        }
        
        public void ConsultaProveedor(string txt)
        {
            try
            {
                int i = 0;
                string idp;
                string id;
                string fecha;

                conn.Open();
                string query0 = "select id_proveedor from proveedor where nombre = '" + txt + "'";
                NpgsqlCommand conector0 = new NpgsqlCommand(query0, conn);
                NpgsqlDataReader reader0 = conector0.ExecuteReader();
                reader0.Read();
                idp = reader0.GetInt32(0).ToString();
                conn.Close();
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_compra, fecha from compra where id_proveedor = '" + idp + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    fecha = reader.GetDate(1).ToString();
                    dataGridView1.Rows.Insert(i, id, txt, fecha);
                    i++;
                }
                conn.Close();
            }
            catch (Exception)
            {
            }
            
        }

        public void ConsultaFecha(string txt)
        {
            try
            {
                    dataGridView1.Rows.Clear();
                    int i = 0;
                    string id;
                    string fecha2 = DateTime.Parse(txt).ToString("yyyy-MM-dd");
                    string fecha;
                    string nombre;
                    conn.Open();
                    string query = "select id_compra, id_proveedor, fecha from compra where fecha = '" + fecha2 + "'";
                    NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader reader = conector.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0).ToString();
                        fecha = reader.GetDate(2).ToString();
                        string query2 = "select nombre from proveedor where id_proveedor = '" + reader.GetInt32(1) + "'";
                        conn2.Open();
                        NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                        NpgsqlDataReader reader2 = conector2.ExecuteReader();
                        reader2.Read();
                        nombre = reader2.GetString(0);
                        conn2.Close();
                        dataGridView1.Rows.Insert(i, id, nombre, fecha);
                        i++;
                    }

                    conn.Close();
            }
            catch(Exception)
            {
            }
        }

        public void ConsultaAmbos(string txt, string txt2)
        {
            try
            {
                int i = 0;
                string idp;
                string id;
                string fecha;
                string fecha2 = DateTime.Parse(txt2).ToString("yyyy-MM-dd");

                conn.Open();
                string query0 = "select id_proveedor from proveedor where nombre = '" + txt + "'";
                NpgsqlCommand conector0 = new NpgsqlCommand(query0, conn);
                NpgsqlDataReader reader0 = conector0.ExecuteReader();
                reader0.Read();
                idp = reader0.GetInt32(0).ToString();
                conn.Close();
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_compra, fecha from compra where id_proveedor = '" + idp + "' AND fecha = '" + fecha2 + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    fecha = reader.GetDate(1).ToString();
                    dataGridView1.Rows.Insert(i, id, txt, fecha);
                    i++;
                }
                conn.Close();
            }
            catch (Exception)
            {
            }

        }


        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            if(Buscar.Text != "")
            {
                try
                {
                    if (Buscar.Text.All(char.IsDigit))
                        ConsultarC(Convert.ToInt32(Buscar.Text));
                }
                catch (Exception)
                {
                    
                }
            }
            else
                ConsultarC();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            string proveedor;
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Id_compra.Text = id.ToString();
            proveedor = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            Nombre.Text = proveedor;
            Fecha.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);

            conn.Open();
            string query = "select id_proveedor from compra where id_compra = '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            reader.Read();
            Id_proveedor.Text = reader.GetInt32(0).ToString();
            conn.Close();

            ConsultarD(id);

            Actualizar_total();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    if (textBox1.Text.All(char.IsDigit))
                        ConsultarP(textBox1.Text);
                    else
                        ConsultarN(textBox1.Text);
                }
                catch (Exception)
                {

                }
            }
            else if (Id_compra.Text != "")
            {
                ConsultarD(Convert.ToInt32(Id_compra.Text));
            }
        }

        private void ElegirProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultaProveedor(ElegirProveedor.Text);
            ban1 = true;
            if (ban2 == true)
            {
                if (ElegirProveedor.Text == "Cualquiera" && fecha)
                    ConsultarC();
                else if (fecha)
                    ConsultaProveedor(ElegirProveedor.Text);
                else if (ElegirProveedor.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else
                    ConsultaAmbos(ElegirProveedor.Text, dateTimePicker1.Text);
            }
            else if (ElegirProveedor.Text == "Cualquiera")
                ConsultarC();
            else
                ConsultaProveedor(ElegirProveedor.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ban2 = true;
            fecha = false;
            if (ban1 == true)
            {
                if (ElegirProveedor.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else
                    ConsultaAmbos(ElegirProveedor.Text, dateTimePicker1.Text);
            }
            else
                ConsultaFecha(dateTimePicker1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fecha = true;
            if (ban1 == true)
            {
                if (ElegirProveedor.Text == "Cualquiera")
                    ConsultarC();
                else
                    ConsultaProveedor(ElegirProveedor.Text);
            }
            else
                ConsultarC();
        }
    }
}
