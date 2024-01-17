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
    public partial class Proveedor : Form
    {
        private bool validado = true;
        private int id;
        private string nombre;
        private string telefono;
        private string correo;
        private bool estado;
        private bool mod = false;

        Validar Validar = new Validar();

        NpgsqlConnection conn = new NpgsqlConnection("Server = insertserver; User Id= insertuser; Password = insertpassword; Database = insertdatabase");

        public Proveedor()
        {
            InitializeComponent();
            conn.Open();
            dataGridView2.DataSource = Consultar();
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
            string query = "select id_proveedor, nombre, estado, telefono, correo from proveedor where nombre != 'Cualquiera'";
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
                    string query = "select id_proveedor, nombre, estado, telefono, correo from proveedor where id_proveedor = '" + txt + "' AND nombre != 'Cualquiera'";
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
                    string query = "select id_proveedor, nombre, estado, telefono, correo from proveedor where nombre = '" + txt + "' AND nombre != 'Cualquiera'";
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
        public DataTable ConsultaEstado(string txt)
        {
            string estado = "";
            if (txt == "Activo")
                estado = "true";
            else if (txt == "Inactivo")
                estado = "false";

            try
            {
                string query = "select id_proveedor, nombre, estado, telefono, correo from proveedor where estado = '" + estado + "' AND nombre != 'Cualquiera'";
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
            string query = "select id_proveedor from proveedor";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();

            int max = 0;

            Nombre.Text = "";
            Telefono.Text = "";
            Correo.Text = "";
            Estado.Text = "";

            while (reader.Read())
            {
                if (reader.GetInt32(0) > max)
                    max = reader.GetInt32(0);
            }
            max++;
            ID.Text = max.ToString();

            Nombre.Enabled = true;
            Estado.Enabled = true;
            Telefono.Enabled = true;
            Correo.Enabled = true;
            Modificar.Enabled = false;
            conn.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            conn.Open();
            validado = true;
            nombre = Nombre.Text;
            telefono = Telefono.Text;
            correo = Correo.Text;
            estado = true;

            if (!Validar.Llenado(ID.Text, "a"))
                validado = false;
            else
                id = int.Parse(ID.Text);

            if (!Validar.Llenado(nombre, "Nombre"))
                validado = false;

            if (!Validar.Llenado(telefono, "Número Telefónico"))
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
                    sql = "INSERT INTO proveedor (id_proveedor, nombre, telefono, correo, estado) VALUES ('" + id + "','" + nombre + "','" + telefono + "','" + correo + "','" + estado + "')";
                }
                else if (mod)
                {
                    sql = "UPDATE proveedor SET id_proveedor='" + id + "', nombre='" + nombre + "',telefono='" + telefono + "', correo='" + correo + "', estado='" + estado +
                        "' WHERE id_proveedor='" + id + "'";
                    mod = false;
                }

                try
                {
                    NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado.");
                    Nombre.Text = "";
                    Telefono.Text = "";
                    ID.Text = "";
                    Nombre.Text = "";
                    Correo.Text = "";
                    Estado.Text = "";
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
            if (Buscar.Text == "")
                dataGridView2.DataSource = Consultar();
            else
                dataGridView2.DataSource = Consultar(Buscar.Text);
            conn.Close();
        }

        private void Telefono_TextChanged(object sender, EventArgs e)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(dataGridView2.SelectedRows[0].Cells[0].Value);
            string nombre = Convert.ToString(dataGridView2.SelectedRows[0].Cells[1].Value);
            string estado = Convert.ToString(dataGridView2.SelectedRows[0].Cells[2].Value);
            string telefono = Convert.ToString(dataGridView2.SelectedRows[0].Cells[3].Value);
            string correo = Convert.ToString(dataGridView2.SelectedRows[0].Cells[4].Value);
            ID.Text = id;
            Nombre.Text = nombre;

            if (estado == "True")
                Estado.Text = "Activo";
            else if (estado == "False")
                Estado.Text = "Inactivo";

            Telefono.Text = telefono;
            Correo.Text = correo;

            Nombre.Enabled = false;
            Estado.Enabled = false;
            Telefono.Enabled = false;
            Correo.Enabled = false;
            Modificar.Enabled = true;
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Buscar.Text == "")
                dataGridView2.DataSource = Consultar();
            else
                dataGridView2.DataSource = Consultar(Buscar.Text);
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Nombre.Enabled = true;
            Estado.Enabled = true;
            Telefono.Enabled = true;
            Correo.Enabled = true;
            Modificar.Enabled = false;
            mod = true;
        }

        private void ElegirEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ElegirEstado.Text != "Cualquiera")
                dataGridView2.DataSource = ConsultaEstado(ElegirEstado.Text);
            else
                dataGridView2.DataSource = Consultar();
        }
    }
}
