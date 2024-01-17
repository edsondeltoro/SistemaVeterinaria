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
    public partial class ConsultarVenta : Form
    {
        Validar Validar = new Validar();

        private bool ban1 = false;
        private bool ban2 = false;
        private bool ban3 = false;
        private bool fecha = true;

        NpgsqlConnection conn = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");
        NpgsqlConnection conn2 = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");
        NpgsqlConnection conn3 = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");

        public ConsultarVenta()
        {
            InitializeComponent();
            ConsultarC();
            DataTable dt = ConsultarEmpleados();
            ElegirEmpleado.DataSource = dt;
            ElegirEmpleado.ValueMember = "nombre";
            DataTable dt2 = ConsultarMascotas();
            ElegirMascota.DataSource = dt2;
            ElegirMascota.ValueMember = "nombre";
        }

        public DataTable ConsultarEmpleados()
        {
            conn.Open();
            string query = "select nombre from empleado";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            conn.Close();

            return tabla;
        }
        public DataTable ConsultarMascotas()
        {

                
                string query = "select nombre from mascota";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                conn.Close();

                return tabla;
            

               
        }

        public void ConsultarC()
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            string id;
            string fecha;
            string nombre_e;
            string nombre_m = "";
            string query3;
            conn.Open();
            string query = "select id_venta, id_empleado, id_mascota, fecha from venta";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
                fecha = reader.GetDateTime(3).ToString();
                string query2 = "select nombre from empleado where id_empleado = '" + reader.GetInt32(1) + "'";
                conn2.Open();
                NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                NpgsqlDataReader reader2 = conector2.ExecuteReader();
                reader2.Read();
                nombre_e = reader2.GetString(0);
                conn2.Close();
                try
                {
                    query3 = "select nombre from mascota where id_mascota = '" + reader.GetInt32(2) + "'";
                    conn3.Open();
                    NpgsqlCommand conector3 = new NpgsqlCommand(query3, conn3);
                    NpgsqlDataReader reader3 = conector3.ExecuteReader();
                    reader3.Read();
                    nombre_m = reader3.GetString(0);
                    conn3.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
                dataGridView1.Rows.Insert(i, id, nombre_e, nombre_m, fecha);
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
                        string nombre_e;
                        string nombre_m;
                        conn.Open();
                        string query = "select id_venta, id_empleado, id_mascota, fecha from venta where id_venta= '" + txt + "'";
                        NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                        NpgsqlDataReader reader = conector.ExecuteReader();
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0).ToString();
                            fecha = reader.GetDateTime(3).ToString();
                            string query2 = "select nombre from empleado where id_empleado = '" + reader.GetInt32(1) + "'";
                            conn2.Open();
                            NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                            NpgsqlDataReader reader2 = conector2.ExecuteReader();
                            reader2.Read();
                            nombre_e = reader2.GetString(0);
                            conn2.Close();
                            string query3 = "select nombre from mascota where id_mascota = '" + reader.GetInt32(1) + "'";
                            conn3.Open();
                            NpgsqlCommand conector3 = new NpgsqlCommand(query3, conn3);
                            NpgsqlDataReader reader3 = conector3.ExecuteReader();
                            reader3.Read();
                            nombre_m = reader3.GetString(0);
                            conn3.Close();
                            dataGridView1.Rows.Insert(i, id, nombre_e, nombre_m, fecha);
                            i++;
                        }
                        conn.Close();
                        break;
                    }
                }
                catch (Exception )
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
                catch (Exception )
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
                catch (Exception )
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
            string query = "select id_producto, cantidad, precio from detalle_venta where id_venta= '" + txt + "'";
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

        public void ConsultaEmpleado(string empleado)
        {
            try
            {
                int i = 0;
                string id_venta;
                string mascota;
                string fecha;
                string id_empleado;

                conn.Open();
                string query0 = "select id_empleado from empleado where nombre = '" + empleado + "'";
                NpgsqlCommand conector0 = new NpgsqlCommand(query0, conn);
                NpgsqlDataReader reader0 = conector0.ExecuteReader();
                reader0.Read();
                id_empleado = reader0.GetInt32(0).ToString();
                conn.Close();
                
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_venta, id_mascota, fecha from venta where id_empleado = '" + id_empleado + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id_venta = reader.GetInt32(0).ToString();
                    string query2 = "select nombre from mascota where id_mascota = '" + reader.GetInt32(1) + "'";
                    conn2.Open();
                    NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                    NpgsqlDataReader reader2 = conector2.ExecuteReader();
                    reader2.Read();
                    mascota = reader2.GetString(0);
                    conn2.Close();
                    fecha = reader.GetDateTime(2).ToString();
                    dataGridView1.Rows.Insert(i, id_venta, empleado, mascota, fecha);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void ConsultaMascota(string mascota)
        {
            try
            {
                int i = 0;
                string id_venta;
                string empleado;
                string fecha;
                string id_mascota;

                conn.Open();
                string query0 = "select id_mascota from mascota where nombre = '" + mascota + "'";
                NpgsqlCommand conector0 = new NpgsqlCommand(query0, conn);
                NpgsqlDataReader reader0 = conector0.ExecuteReader();
                reader0.Read();
                id_mascota = reader0.GetInt32(0).ToString();
                conn.Close();
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_venta, id_empleado, fecha from venta where id_mascota = '" + id_mascota + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id_venta = reader.GetInt32(0).ToString();
                    string query2 = "select nombre from empleado where id_empleado = '" + reader.GetInt32(1) + "'";
                    conn2.Open();
                    NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                    NpgsqlDataReader reader2 = conector2.ExecuteReader();
                    reader2.Read();
                    empleado = reader2.GetString(0);
                    conn2.Close();
                    fecha = reader.GetDateTime(2).ToString();
                    dataGridView1.Rows.Insert(i, id_venta, empleado, mascota, fecha);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ConsultaFecha(string txt)
        {
            try
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                string id;
                string fecha = DateTime.Parse(txt).ToString("yyyy-MM-dd");
                string empleado;
                string mascota;
                conn.Open();
                string query = "select id_venta, id_empleado, id_mascota from compra where fecha = '" + fecha + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    string query2 = "select nombre from empleado where id_empleado = '" + reader.GetInt32(1) + "'";
                    conn2.Open();
                    NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                    NpgsqlDataReader reader2 = conector2.ExecuteReader();
                    reader2.Read();
                    empleado = reader2.GetString(0);
                    conn2.Close();
                    string query3 = "select nombre from mascota where id_mascota = '" + reader.GetInt32(2) + "'";
                    conn2.Open();
                    NpgsqlCommand conector3 = new NpgsqlCommand(query3, conn2);
                    NpgsqlDataReader reader3 = conector3.ExecuteReader();
                    reader3.Read();
                    mascota = reader3.GetString(0);
                    conn2.Close();
                    dataGridView1.Rows.Insert(i, id, empleado, mascota, fecha);
                    i++;
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ConsultaEyM(string empleado, string mascota)
        {
            try
            {
                int i = 0;
                string id;
                string ide;
                string idm;
                string fecha;

                conn.Open();
                string query0 = "select id_empleado from empleado where nombre = '" + empleado + "'";
                NpgsqlCommand conector0 = new NpgsqlCommand(query0, conn);
                NpgsqlDataReader reader0 = conector0.ExecuteReader();
                reader0.Read();
                ide = reader0.GetInt32(0).ToString();
                conn.Close();
                
                conn.Open();
                string query1 = "select id_mascota from mascota where nombre = '" + mascota + "'";
                NpgsqlCommand conector1 = new NpgsqlCommand(query1, conn);
                NpgsqlDataReader reader1 = conector1.ExecuteReader();
                reader1.Read();
                idm = reader1.GetInt32(0).ToString();
                conn.Close();
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_venta, fecha from venta where id_empleado = '" + ide + "' AND id_mascota = '" + idm + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    fecha = reader.GetDateTime(1).ToString();
                    dataGridView1.Rows.Insert(i, id, empleado, mascota, fecha);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void ConsultaEyF(string empleado, string txt)
        {
            try
            {
                int i = 0;
                string id;
                string ide;
                string mascota;
                string fecha = DateTime.Parse(txt).ToString("yyyy-MM-dd");

                conn.Open();
                string query0 = "select id_empleado from empleado where nombre = '" + empleado + "'";
                NpgsqlCommand conector0 = new NpgsqlCommand(query0, conn);
                NpgsqlDataReader reader0 = conector0.ExecuteReader();
                reader0.Read();
                ide = reader0.GetInt32(0).ToString();
                
                conn.Close();
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_venta, id_mascota from venta where id_empleado = '" + ide + "' AND fecha = '" + fecha + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    string query1 = "select nombre from mascota where id_mascota = '" + reader.GetInt32(1) + "'";
                    conn2.Open();
                    NpgsqlCommand conector1 = new NpgsqlCommand(query1, conn2);
                    NpgsqlDataReader reader1 = conector1.ExecuteReader();
                    reader1.Read();
                    mascota = reader1.GetString(0);
                    conn2.Close();
                    dataGridView1.Rows.Insert(i, id, empleado, mascota, fecha);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ConsultaMyF(string mascota, string txt)
        {
            try
            {
                int i = 0;
                string id;
                string idm;
                string empleado;
                string fecha = DateTime.Parse(txt).ToString("yyyy-MM-dd");

                conn.Open();
                string query0 = "select id_mascota from mascota where nombre = '" + mascota + "'";
                NpgsqlCommand conector0 = new NpgsqlCommand(query0, conn);
                NpgsqlDataReader reader0 = conector0.ExecuteReader();
                reader0.Read();
                idm = reader0.GetInt32(0).ToString();
                conn.Close();
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_venta, id_empleado from venta where id_mascota = '" + idm + "' AND fecha = '" + fecha + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    string query1 = "select nombre from empleado where id_empleado = '" + reader.GetInt32(1) + "'";
                    conn2.Open();
                    NpgsqlCommand conector1 = new NpgsqlCommand(query1, conn2);
                    NpgsqlDataReader reader1 = conector1.ExecuteReader();
                    reader1.Read();
                    empleado = reader1.GetString(0);
                    conn2.Close();
                    dataGridView1.Rows.Insert(i, id, empleado, mascota, fecha);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void ConsultaTodos(string empleado, string mascota, string txt)
        {
            try
            {
                int i = 0;
                string id;
                string ide;
                string idm;
                string fecha = DateTime.Parse(txt).ToString("yyyy-MM-dd");
                conn.Open();
                string query0 = "select id_empleado from empleado where nombre = '" + empleado + "'";
                NpgsqlCommand conector0 = new NpgsqlCommand(query0, conn);
                NpgsqlDataReader reader0 = conector0.ExecuteReader();
                reader0.Read();
                ide = reader0.GetInt32(0).ToString();
                
                conn.Close();
                conn.Open();
                string query1 = "select id_mascota from mascota where nombre = '" + mascota + "'";
                NpgsqlCommand conector1 = new NpgsqlCommand(query1, conn);
                NpgsqlDataReader reader1 = conector1.ExecuteReader();
                reader1.Read();
                idm = reader1.GetInt32(0).ToString();
                conn.Close();
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_venta from venta where id_empleado = '" + ide + "' AND id_mascota = '" + mascota + "' AND fecha = '" + fecha + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    dataGridView1.Rows.Insert(i, id, empleado, mascota, fecha);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

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

        private void Buscar_TextChanged_1(object sender, EventArgs e)
        {
            if (Buscar.Text != "")
            {
                try
                {
                    if (Buscar.Text.All(char.IsDigit))
                        ConsultarC(Convert.ToInt32(Buscar.Text));
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
            }
            else
                ConsultarC();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            string nombre_e;
            string nombre_m;
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Id_venta.Text = id.ToString();
            nombre_e = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            nombre_m = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            Nombre_e.Text = nombre_e;
            Nombre_m.Text = nombre_m;
            Fecha_c.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);

            conn.Open();
            string query = "select id_empleado from venta where id_venta = '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            reader.Read();
            Id_empleado.Text = reader.GetInt32(0).ToString();
            conn.Close();

            conn.Open();
            query = "select id_mascota from venta where id_venta = '" + id + "'";
            NpgsqlCommand conector2 = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader2 = conector2.ExecuteReader();
            reader2.Read();
            try
            {
                Id_mascota.Text = reader2.GetInt32(0).ToString();
            }
            catch
            {
                Id_mascota.Text = "General";
            }
            conn.Close();

            ConsultarD(id);

            Actualizar_total();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
            }
            else if (Id_venta.Text != "")
            {
                ConsultarD(Convert.ToInt32(Id_venta.Text));
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            
            ban3 = true;
            fecha = false;
            if (ban1 == true && ban2 == true)
            {
                if (ElegirEmpleado.Text == "Cualquiera" && ElegirMascota.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else if (ElegirMascota.Text == "Cualquiera")
                    ConsultaEyF(ElegirEmpleado.Text, dateTimePicker1.Text);
                else if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultaMyF(ElegirMascota.Text, dateTimePicker1.Text);
                else
                    ConsultaTodos(ElegirEmpleado.Text, ElegirMascota.Text, dateTimePicker1.Text);
            }
            else if (ban1 == true && ban2 == false)
            {
                if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else
                    ConsultaEyF(ElegirEmpleado.Text, dateTimePicker1.Text);
            }
            else if (ban1 == false && ban2 == true)
            {
                if (ElegirMascota.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else
                    ConsultaMyF(ElegirMascota.Text, dateTimePicker1.Text);
            }
            else
                ConsultaFecha(dateTimePicker1.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            fecha = true;
            if (ban1 == true && ban2 == true)
            {
                if (ElegirEmpleado.Text == "Cualquiera" && ElegirMascota.Text == "Cualquiera")
                    ConsultarC();
                else if (ElegirMascota.Text == "Cualquiera")
                    ConsultaEmpleado(ElegirEmpleado.Text);
                else if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultaMascota(ElegirMascota.Text);
                else
                    ConsultaEyM(ElegirEmpleado.Text, ElegirMascota.Text);
            }
            else if (ban1 == true && ban2 == false)
            {
                if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultarC();
                else
                    ConsultaEmpleado(ElegirEmpleado.Text);
            }
            else if (ban1 == false && ban2 == true)
            {
                if (ElegirMascota.Text == "Cualquiera")
                    ConsultarC();
                else
                    ConsultaMascota(ElegirMascota.Text);
            }
            else
                ConsultarC();
            
        }

        private void ElegirMascota_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ban2 = true;
            if (ban1 == true && ban3 == true)
            {
                if (ElegirEmpleado.Text == "Cualquiera" && ElegirMascota.Text == "Cualquiera" && fecha)
                    ConsultarC();
                else if (ElegirMascota.Text == "Cualquiera" && fecha)
                    ConsultaEmpleado(ElegirEmpleado.Text);
                else if (ElegirEmpleado.Text == "Cualquiera" && fecha)
                    ConsultaMascota(ElegirMascota.Text);
                else if (ElegirEmpleado.Text == "Cualquiera" && ElegirMascota.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else if (fecha)
                    ConsultaEyM(ElegirEmpleado.Text, ElegirMascota.Text);
                else if (ElegirMascota.Text == "Cualquiera")
                    ConsultaEyF(ElegirEmpleado.Text, dateTimePicker1.Text);
                else if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultaMyF(ElegirMascota.Text, dateTimePicker1.Text);
                else
                    ConsultaTodos(ElegirEmpleado.Text, ElegirMascota.Text, dateTimePicker1.Text);
            }
            else if (ban1 == true && ban3 == false)
            {
                if (ElegirEmpleado.Text == "Cualquiera" && ElegirMascota.Text == "Cualquiera")
                    ConsultarC();
                else if (ElegirMascota.Text == "Cualquiera")
                    ConsultaEmpleado(ElegirEmpleado.Text);
                else if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultaMascota(ElegirMascota.Text);
                else
                    ConsultaEyM(ElegirEmpleado.Text, ElegirMascota.Text);
            }
            else if (ban1 == false && ban3 == true)
            {
                if (ElegirMascota.Text == "Cualquiera" && fecha)
                    ConsultarC();
                else if (fecha)
                    ConsultaMascota(ElegirMascota.Text);
                else if (ElegirMascota.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else
                    ConsultaMyF(ElegirMascota.Text, dateTimePicker1.Text);
            }
            else if (ElegirMascota.Text != "Cualquiera")
                ConsultaMascota(ElegirMascota.Text);
            else
                ConsultarC();
        }

        private void ElegirEmpleado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ban1 = true;
            if (ban2 == true && ban3 == true)
            {
                if (ElegirEmpleado.Text == "Cualquiera" && ElegirMascota.Text == "Cualquiera" && fecha)
                    ConsultarC();
                else if (ElegirMascota.Text == "Cualquiera" && fecha)
                    ConsultaEmpleado(ElegirEmpleado.Text);
                else if (ElegirEmpleado.Text == "Cualquiera" && fecha)
                    ConsultaMascota(ElegirMascota.Text);
                else if (ElegirEmpleado.Text == "Cualquiera" && ElegirMascota.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else if (fecha)
                    ConsultaEyM(ElegirEmpleado.Text, ElegirMascota.Text);
                else if (ElegirMascota.Text == "Cualquiera")
                    ConsultaEyF(ElegirEmpleado.Text, dateTimePicker1.Text);
                else if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultaMyF(ElegirMascota.Text, dateTimePicker1.Text);
                else
                    ConsultaTodos(ElegirEmpleado.Text, ElegirMascota.Text, dateTimePicker1.Text);
            }
            else if (ban2 == true && ban3 == false)
            {
                if (ElegirEmpleado.Text == "Cualquiera" && ElegirMascota.Text == "Cualquiera")
                    ConsultarC();
                else if (ElegirMascota.Text == "Cualquiera")
                    ConsultaEmpleado(ElegirEmpleado.Text);
                else if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultaMascota(ElegirMascota.Text);
                else
                    ConsultaEyM(ElegirEmpleado.Text, ElegirMascota.Text);
            }
            else if (ban2 == false && ban3 == true)
            {
                if (ElegirEmpleado.Text == "Cualquiera" && fecha)
                    ConsultarC();
                else if (fecha)
                    ConsultaEmpleado(ElegirEmpleado.Text);
                else if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else
                    ConsultaEyF(ElegirEmpleado.Text, dateTimePicker1.Text);
            }
            else if (ElegirEmpleado.Text != "Cualquiera")
                ConsultaEmpleado(ElegirEmpleado.Text);
            else
                ConsultarC();
        }
    }
}
