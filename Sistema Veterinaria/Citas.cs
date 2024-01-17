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
    public partial class Citas : Form
    {
        private bool ban1 = false;
        private bool ban2 = false;
        private bool ban3 = false;
        private bool fecha = true;
        private bool mod = false;

        NpgsqlConnection conn = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");
        NpgsqlConnection conn2 = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");

        public Citas()
        {
            InitializeComponent();
            ConsultarC();
            DataTable dt2 = ConsultarMascotas();
            DataTable dt3 = ConsultarMascotas2();
            ElegirMascota.DataSource = dt2;
            ElegirMascota.ValueMember = "nombre";
            comboBox2.DataSource = dt3;
            comboBox2.ValueMember = "nombre";
            textBox1.Text = Global.getid().ToString();
        }

        public DataTable ConsultarMascotas()
        {
            conn.Open();
            string query = "select nombre from mascota";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            conn.Close();

            return tabla;
        }

        public DataTable ConsultarMascotas2()
        {
            conn.Open();
            string query = "select nombre from mascota where estado = true";
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
            string nombre_m = "";
            string estado;
            string query2;
            conn.Open();
            string query = "select id_cita, id_mascota, fecha, estado from citas";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
                fecha = reader.GetDateTime(2).ToString();
                if (reader.GetBoolean(3))
                    estado = "Completada";
                else
                    estado = "Pendiente";
                try
                {
                    query2 = "select nombre from mascota where id_mascota = '" + reader.GetInt32(1) + "'";
                    conn2.Open();
                    NpgsqlCommand conector3 = new NpgsqlCommand(query2, conn2);
                    NpgsqlDataReader reader3 = conector3.ExecuteReader();
                    reader3.Read();
                    nombre_m = reader3.GetString(0);
                    conn2.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                    conn.Close();
                    conn2.Close();
                }
                dataGridView1.Rows.Insert(i, id, nombre_m, fecha, estado);
                i++;
            }
            conn.Close();
        }

        public void ConsultaEstado(string txt)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            string id;
            string fecha;
            string nombre_m = "";
            string query2;
            bool estado;
            if (txt == "Completada")
                estado = true;
            else
                estado = false;
            conn.Open();
            string query = "select id_cita, id_mascota, fecha from citas where estado = '" + estado + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
                fecha = reader.GetDateTime(2).ToString();
                try
                {
                    query2 = "select nombre from mascota where id_mascota = '" + reader.GetInt32(1) + "'";
                    conn2.Open();
                    NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                    NpgsqlDataReader reader2 = conector2.ExecuteReader();
                    reader2.Read();
                    nombre_m = reader2.GetString(0);
                    conn2.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                    conn.Close();
                    conn2.Close();
                }
                dataGridView1.Rows.Insert(i, id, nombre_m, fecha, txt);
                i++;
            }
            conn.Close();
        }
        public void ConsultaMascota(string mascota)
        {
            try
            {
                int i = 0;
                string id;
                string fecha;
                string estado;
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
                string query = "select id_cita, estado, fecha from citas where id_mascota = '" + id_mascota + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    if (reader.GetBoolean(1))
                        estado = "Completada";
                    else
                        estado = "Pendiente";
                    fecha = reader.GetDateTime(2).ToString();
                    dataGridView1.Rows.Insert(i, id, mascota, fecha, estado);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                
                conn.Close();
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
                string estado;
                string mascota;
                conn.Open();
                string query = "select id_cita, estado, id_mascota from citas where fecha = '" + fecha + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    if (reader.GetBoolean(1))
                        estado = "Completada";
                    else
                        estado = "Pendiente";
                    string query2 = "select nombre from mascota where id_mascota = '" + reader.GetInt32(2) + "'";
                    conn2.Open();
                    NpgsqlCommand conector2 = new NpgsqlCommand(query2, conn2);
                    NpgsqlDataReader reader2 = conector2.ExecuteReader();
                    reader2.Read();
                    mascota = reader2.GetString(0);
                    conn2.Close();
                    dataGridView1.Rows.Insert(i, id, mascota, fecha, estado);
                    i++;
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
                conn2.Close();
            }
        }

        public void ConsultaEyM(string txt, string mascota)
        {
            try
            {
                int i = 0;
                string id;
                string idm;
                string fecha;
                bool estado;

                if (txt == "Completada")
                    estado = true;
                else
                    estado = false;

                conn.Open();
                string query1 = "select id_mascota from mascota where nombre = '" + mascota + "'";
                NpgsqlCommand conector1 = new NpgsqlCommand(query1, conn);
                NpgsqlDataReader reader1 = conector1.ExecuteReader();
                reader1.Read();
                idm = reader1.GetInt32(0).ToString();
                conn.Close();
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_cita, fecha from citas where estado = '" + estado + "' AND id_mascota = '" + idm + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    fecha = reader.GetDateTime(1).ToString();
                    dataGridView1.Rows.Insert(i, id, mascota, fecha, txt);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }

        }

        public void ConsultaEyF(string txt1, string txt)
        {
            try
            {
                int i = 0;
                string id;
                string mascota;
                bool estado;
                string fecha = DateTime.Parse(txt).ToString("yyyy-MM-dd");

                if (txt1 == "Completada")
                    estado = true;
                else
                    estado = false;

                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_cita, id_mascota from citas where estado = '" + estado + "' AND fecha = '" + fecha + "'";
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
                    dataGridView1.Rows.Insert(i, id, mascota, fecha, txt1);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
                conn2.Close();
            }
        }

        public void ConsultaMyF(string mascota, string txt)
        {
            try
            {
                int i = 0;
                string id;
                string idm;
                string estado;
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
                string query = "select id_cita, estado from citas where id_mascota = '" + idm + "' AND fecha = '" + fecha + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    if (reader.GetBoolean(1))
                        estado = "Completada";
                    else
                        estado = "Pendiente";
                    dataGridView1.Rows.Insert(i, id, mascota, fecha, estado);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }

        }

        public void ConsultaTodos(string txt1, string mascota, string txt)
        {
            try
            {
                int i = 0;
                string id;
                bool estado;
                string idm;
                string fecha = DateTime.Parse(txt).ToString("yyyy-MM-dd");

                if (txt1 == "Completada")
                    estado = true;
                else
                    estado = false;

                conn.Open();
                string query1 = "select id_mascota from mascota where nombre = '" + mascota + "'";
                NpgsqlCommand conector1 = new NpgsqlCommand(query1, conn);
                NpgsqlDataReader reader1 = conector1.ExecuteReader();
                reader1.Read();
                idm = reader1.GetInt32(0).ToString();
                conn.Close();
                dataGridView1.Rows.Clear();
                conn.Open();
                string query = "select id_cita from citas where estado = '" + estado + "' AND id_mascota = '" + idm + "' AND fecha = '" + fecha + "'";
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataReader reader = conector.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    dataGridView1.Rows.Insert(i, id, mascota, fecha, txt1);
                    i++;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                conn.Close();
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            string nombre_e;
            string nombre_m;
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            ID.Text = id.ToString();
            nombre_e = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            comboBox2.Text = nombre_e;
            dateTimePicker2.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);

            conn.Open();
            string query = "select id_empleado, hora, descripcion from citas where id_cita = '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            reader.Read();
            textBox1.Text = reader.GetInt32(0).ToString();
            comboBox1.Text = reader.GetTimeSpan(1).ToString();
            Detalles.Text = reader.GetString(2);
            conn.Close();

            Modificar.Enabled = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            Detalles.Enabled = false;
            dateTimePicker2.Enabled = false;
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
                    ConsultaEstado(ElegirEmpleado.Text);
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
                    ConsultaEstado(ElegirEmpleado.Text);
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
                    ConsultaEstado(ElegirEmpleado.Text);
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
                    ConsultaEstado(ElegirEmpleado.Text);
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
                    ConsultaEstado(ElegirEmpleado.Text);
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
                    ConsultaEstado(ElegirEmpleado.Text);
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
                    ConsultaEstado(ElegirEmpleado.Text);
                else if (ElegirEmpleado.Text == "Cualquiera")
                    ConsultaFecha(dateTimePicker1.Text);
                else
                    ConsultaEyF(ElegirEmpleado.Text, dateTimePicker1.Text);
            }
            else if (ElegirEmpleado.Text != "Cualquiera")
                ConsultaEstado(ElegirEmpleado.Text);
            else
                ConsultarC();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            textBox1.Text = Global.getid().ToString();
            mod = false;
            conn2.Open();
            string query = "select id_cita from citas";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn2);
            NpgsqlDataReader reader = conector.ExecuteReader();

            int max = 0;
            while (reader.Read())
            {
                if (reader.GetInt32(0) > max)
                    max = reader.GetInt32(0);
            }
            max++;
            ID.Text = max.ToString();

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "Pendiente";
            dateTimePicker2.Text = "";
            Detalles.Text = "";
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            dateTimePicker2.Enabled = true;
            Detalles.Enabled = true;
            Modificar.Enabled = false;
            conn2.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            textBox1.Text = Global.getid().ToString();
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            dateTimePicker2.Enabled = true;
            Detalles.Enabled = true;
            Modificar.Enabled = false;
            mod = true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            float monto = 100;
            string id_cita = ID.Text;
            bool estado;

            string id_mas;
            conn2.Open();
            string query1 = "select id_mascota from mascota where nombre = '" + comboBox2.Text + "'";
            NpgsqlCommand conector1 = new NpgsqlCommand(query1, conn2);
            NpgsqlDataReader reader1 = conector1.ExecuteReader();
            reader1.Read();
            id_mas = reader1.GetInt32(0).ToString();
            conn2.Close();
            if (comboBox3.Text == "Completada")
                estado = true;
            else
                estado = false;
            string id_emp = textBox1.Text;
            string Date = DateTime.Parse(dateTimePicker2.Text).ToString("yyyy-MM-dd");
            string Time = comboBox1.Text;
            string Desc = Detalles.Text;

            //insertar datos en tabla cita
            try
            {
                conn.Open();
                string query = null;
                if (!mod)
                {
                    query = "INSERT INTO citas (id_cita, id_mascota, id_empleado, fecha, hora, descripcion, precio, estado) VALUES ('" + id_cita + "','" + id_mas + "','" + id_emp + "','" +
                    Date + "','" + Time + "','" + Desc + "','" + monto + "','" + estado + "')";
                }
                else if (mod)
                {
                    query = "UPDATE citas SET id_cita='" + id_cita + "', id_mascota='" + id_mas + "', id_empleado='" + id_emp + "', fecha='" + Date + "', hora='" + Time + "', " +
                        "descripcion='" + Desc + "', precio='" + monto + "', estado='" + estado + "' WHERE id_cita='" + id_cita + "'";
                    mod = false;
                }

                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                conector.ExecuteNonQuery();
                MessageBox.Show("Registro guardado.");
                DataTable dt2 = ConsultarMascotas();
                DataTable dt3 = ConsultarMascotas2();
                ElegirMascota.DataSource = dt2;
                ElegirMascota.ValueMember = "nombre";
                comboBox2.DataSource = dt3;
                comboBox2.ValueMember = "nombre";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                dateTimePicker2.Text = "";
                Detalles.Text = "";
                conn.Close();
            }
            catch (Exception a)
            {
                conn.Close();
            }

            ConsultarC();
        }
    }
}
