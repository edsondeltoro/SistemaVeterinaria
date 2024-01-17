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
    public partial class Mascota : Form
    {
        private bool validado = true;
        private int id;
        private string nombre;
        private string dueno;
        private string fecha;
        private string direccion;
        private string telefono;
        private bool ban1 = false;
        private bool ban2 = false;
        private bool estado;
        private bool mod = false;

        Validar Validar = new Validar();

        NpgsqlConnection conn = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");

        public Mascota()
        {
            InitializeComponent();
            conn.Open();
            dataGridView1.DataSource = Consultar();
            conn.Close();
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
            string query = "select id_mascota, nombre, nombre_dueno, telefono from mascota where nombre != 'Cualquiera'";
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
                    string query = "select id_mascota, nombre, nombre_dueno, telefono from mascota where id_mascota = '" + txt + "'";
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
                    string query = "select id_mascota, nombre, nombre_dueno, telefono from mascota where nombre = '" + txt + "'";
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

        private void Nuevo_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            mod = false;
            string query = "select id_mascota from mascota";
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
            Fecha.Text = "";
            Telefono.Text = "";
            textBox1.Text = "";
            Sueldo.Text = "";
            Estado.Text = "";
            Nombre.Enabled = true;
            textBox1.Enabled = true;
            Estado.Enabled = true;
            Fecha.Enabled = true;
            Sueldo.Enabled = true;
            Telefono.Enabled = true;
            Modificar.Enabled = false;
            conn.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            conn.Open();
            validado = true;
            nombre = Nombre.Text;
            direccion = Sueldo.Text;
            dueno = textBox1.Text;
            fecha = DateTime.Parse(Fecha.Text).ToString("yyyy-MM-dd");
            telefono = Telefono.Text;
            estado = true;

            if (!Validar.Llenado(ID.Text, "e"))
                validado = false;
            else
                id = int.Parse(ID.Text);

            if (!Validar.Llenado(Telefono.Text, "Número telefónico."))
                validado = false;

            if (!Validar.Llenado(nombre, "Nombre de mascota"))
                validado = false;

            if (!Validar.Llenado(dueno, "Nombre de dueño"))
                validado = false;

            if (!Validar.Llenado(Estado.Text, "Estado"))
                validado = false;

            else if (!validaEstado(Estado.Text))
                validado = false;

            if (validado)
            {
                string sql = null;
                if (!mod)
                {
                    sql = "INSERT INTO mascota (id_mascota, fecha_nacimiento, direccion, nombre, nombre_dueno, telefono, estado) VALUES ('" + id + "','" + fecha + "','" + direccion + "','" +
                    nombre + "','" + dueno + "','" + telefono + "','" + estado + "')";
                }
                else if (mod)
                {
                    sql = "UPDATE mascota SET id_mascota='" + id + "', fecha_nacimiento='" + fecha + "', direccion='" + direccion + "', nombre='" + nombre + "', nombre_dueno='" + dueno + "', " +
                        "telefono='" + telefono + "', estado='" + estado + "' WHERE id_mascota='" + id + "'";
                    mod = false;
                }

                try
                {
                    NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado.");
                    DataTable dt = ConsultarTelefonos();
                    ElegirTelefono.DataSource = dt;
                    ElegirTelefono.ValueMember = "telefono";
                    DataTable dt2 = ConsultarDuenos();
                    ElegirDueno.DataSource = dt2;
                    ElegirDueno.ValueMember = "nombre_dueno";
                    Nombre.Text = "";
                    Fecha.Text = "";
                    Telefono.Text = "";
                    textBox1.Text = "";
                    ID.Text = "";
                    Sueldo.Text = "";
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

        private void Telefono_TextChanged_1(object sender, EventArgs e)
        {
            if (!Telefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("Favor de ingresar solo números.");
                Telefono.Text = null;
            }
            if (Telefono.Text.Length > 10)
            {
                MessageBox.Show("Favor de ingresar solo los 10 dígitos del número telefónico.");
                Telefono.Text = null;
            }
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
            textBox1.Enabled = true;
            Estado.Enabled = true;
            Fecha.Enabled = true;
            Sueldo.Enabled = true;
            Telefono.Enabled = true;
            Modificar.Enabled = false;
            mod = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
            string fecha = null;
            string direccion = null;
            bool estado = true;
            conn.Open();
            string query = "select fecha_nacimiento, direccion, estado from mascota where id_mascota= '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();
            while (reader.Read())
            {
                fecha = Convert.ToString(reader.GetDateTime(0));
                direccion = reader.GetString(1);
                estado = reader.GetBoolean(2);
            }
            conn.Close();

            Fecha.Text = fecha;
            Sueldo.Text = direccion;
            if (estado)
                Estado.Text = "Activo";
            else
                Estado.Text = "Inactivo";

            string nombre = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            string dueno = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            string telefono = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
            
            ID.Text = id;
            Nombre.Text = nombre;
            
            Telefono.Text = telefono;
            textBox1.Text = dueno;
            Nombre.Enabled = false;
            Estado.Enabled = false;
            Fecha.Enabled = false;
            Telefono.Enabled = false;
            Sueldo.Enabled = false;
            textBox1.Enabled = false;
            Modificar.Enabled = true;
        }

        private void ElegirDueno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ban1 = true;
            if (ban2 == true)
            {
                if (ElegirDueno.Text == "Cualquiera" && ElegirTelefono.Text == "Cualquiera")
                    dataGridView1.DataSource = Consultar();
                else if (ElegirTelefono.Text == "Cualquiera")
                    dataGridView1.DataSource = ConsultaDueno(ElegirDueno.Text);
                else if (ElegirDueno.Text == "Cualquiera")
                    dataGridView1.DataSource = ConsultaTelefono(ElegirTelefono.Text);
                else
                    dataGridView1.DataSource = ConsultaAmbos(ElegirDueno.Text, ElegirTelefono.Text);
            }
            else if (ElegirDueno.Text == "Cualquiera")
                dataGridView1.DataSource = Consultar();
            else
                dataGridView1.DataSource = ConsultaDueno(ElegirDueno.Text);
        }

        private void ElegirTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            ban2 = true;
            if (ban1 == true)
            {
                if (ElegirDueno.Text == "Cualquiera" && ElegirTelefono.Text == "Cualquiera")
                    dataGridView1.DataSource = Consultar();
                else if (ElegirTelefono.Text == "Cualquiera")
                    dataGridView1.DataSource = ConsultaDueno(ElegirDueno.Text);
                else if (ElegirDueno.Text == "Cualquiera")
                    dataGridView1.DataSource = ConsultaTelefono(ElegirTelefono.Text);
                else
                    dataGridView1.DataSource = ConsultaAmbos(ElegirDueno.Text, ElegirTelefono.Text);
            }
            else if (ElegirTelefono.Text == "Cualquiera")
                dataGridView1.DataSource = Consultar();
            else
                dataGridView1.DataSource = ConsultaTelefono(ElegirTelefono.Text);
        }
        }
    }
}
