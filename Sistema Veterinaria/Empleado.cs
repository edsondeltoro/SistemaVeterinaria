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
    public partial class Empleado : Form
    {
        private bool validado = true;
        private int id;
        private string nombre;
        private string fecha;
        private string telefono;
        private string cargo;
        private string usuario;
        private string contra;
        private double sueldo;
        private bool estado;
        private bool mod = false;

        Validar Validar = new Validar();

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = Frijolito4819.; Database = veterinaria4");

        public Empleado()
        {
            InitializeComponent();
            conn.Open();
            dataGridView1.DataSource = Consultar();
            conn.Close();
        }

        public bool validaCargo(string txt)
        {
            if (txt == "Mostrador" || txt == "Asistente" || txt == "Intendente" || txt == "Veterinario")
                return true;
            else
            {
                MessageBox.Show("Cargo: (" + Cargo.Text + ") inválido, por favor eliga un cargo válido (Mostrador, Asistente o Intendente)");
                Cargo.Text = null;
                return false;
            }
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
            string query = "select id_empleado, nombre, cargo, estado, fecha_nacimiento, sueldo, telefono, usuario, contrasena from empleado where nombre != 'Cualquiera'";
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
                    string query = "select id_empleado, nombre, cargo, estado, fecha_nacimiento, sueldo, telefono, usuario, contrasena from empleado where id_empleado = '" + txt + "' AND nombre != 'Cualquiera'";
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
                    string query = "select id_empleado, nombre, cargo, estado, fecha_nacimiento, sueldo, telefono, usuario, contrasena from empleado where nombre = '" + txt + "' AND nombre != 'Cualquiera'";
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

        public DataTable ConsultaCargo(string txt)
        {
            try
            {
                string query = "select id_empleado, nombre, cargo, estado, fecha_nacimiento, sueldo, telefono, usuario, contrasena from empleado where cargo = '" + txt + "' AND nombre != 'Cualquiera'";
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
        public DataTable ConsultaEstado(string txt)
        {
            string estado = "";
            if (txt == "Activo")
                estado = "true";
            else if (txt == "Inactivo")
                estado = "false";

            try
            {
                string query = "select id_empleado, nombre, cargo, estado, fecha_nacimiento, sueldo, telefono, usuario, contrasena from empleado where estado = '" + estado + "'AND nombre != 'Cualquiera'";
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
            string estado = "";
            if (txt2 == "Activo")
                estado = "true";
            else if (txt2 == "Inactivo")
                estado = "false";

            try
            {
                string query = "select id_empleado, nombre, cargo, estado, fecha_nacimiento, sueldo, telefono, usuario, contrasena from empleado where estado = '" + estado + "' AND cargo = '" + txt + "'AND nombre != 'Cualquiera'";
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

        private void Nuevo_Click(object sender, EventArgs e)
        {
            conn.Open();
            mod = false;
            string query = "select id_empleado from empleado";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader = conector.ExecuteReader();

            int max = 0;

            Nombre.Text = "";
            Fecha.Text = "";
            Telefono.Text = "";
            Cargo.Text = "";
            Usuario.Text = "";
            Contra.Text = "";

            while (reader.Read())
            {
                if (reader.GetInt32(0) > max)
                    max = reader.GetInt32(0);
            }
            max++;
            ID.Text = max.ToString();

            Sueldo.Text = "";
            Estado.Text = "";
            Nombre.Enabled = true;
            Cargo.Enabled = true;
            Estado.Enabled = true;
            Fecha.Enabled = true;
            Sueldo.Enabled = true;
            Telefono.Enabled = true;
            Usuario.Enabled = true;
            Contra.Enabled = true;
            Modificar.Enabled = false;
            conn.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            conn.Open();
            validado = true;
            nombre = Nombre.Text;
            fecha = DateTime.Parse(Fecha.Text).ToString("yyyy-MM-dd");
            telefono = Telefono.Text;
            cargo = Cargo.Text;
            usuario = Usuario.Text;
            contra = Contra.Text;
            estado = true;

            if (!Validar.Llenado(ID.Text, "b"))
                validado = false;
            else
                id = int.Parse(ID.Text);

            if (!Validar.Llenado(nombre, "Nombre completo"))
                validado = false;

            if (!Validar.Llenado(cargo, "Cargo"))
                validado = false;
            else if (!validaCargo(cargo))
                validado = false;

            if (!Validar.Llenado(Sueldo.Text, "Sueldo"))
                validado = false;

            if (!Validar.Llenado(Usuario.Text, "Usuario"))
                validado = false;

            if (!Validar.Llenado(Contra.Text, "Contraseña"))
                validado = false;
            else
            {
                try
                {
                    sueldo = double.Parse(Sueldo.Text);
                    if (sueldo < 0)
                    {
                        MessageBox.Show("Favor de no ingresar números negativos el campo sueldo.");
                        validado = false;
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Favor de ingresar solo números y puntos decimales en el campo sueldo.");
                    validado = false;
                }
            }

            if (!Validar.Llenado(Estado.Text, "Estado"))
                validado = false;
            else if(!validaEstado(Estado.Text))
                validado = false;

            if (validado)
            {
                string sql = null;
                if (!mod) 
                {
                    sql = "INSERT INTO empleado (id_empleado, fecha_nacimiento, sueldo, nombre, cargo, telefono, estado, usuario, contrasena) VALUES ('" + id + "','" + fecha + "','" + sueldo + "','" +
                    nombre + "','" + cargo + "','" + telefono + "','" + estado + "','" + usuario + "','" + contra + "')";
                }
                else if (mod)
                {
                    sql = "UPDATE empleado SET id_empleado='" + id + "', fecha_nacimiento='" + fecha + "', sueldo='" + sueldo + "', nombre='" + nombre + "', cargo='" + cargo + "', " +
                        "telefono='" + telefono + "', estado='" + estado + "', usuario='" + usuario + "', contrasena='" + contra + "' WHERE id_empleado='" + id + "'";
                    mod = false;
                }

                try
                {
                    NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado.");
                    Nombre.Text = "";
                    Fecha.Text = "";
                    Telefono.Text = "";
                    Cargo.Text = "";
                    ID.Text = "";
                    Nombre.Text = "";
                    Sueldo.Text = "";
                    Estado.Text = "";
                    Usuario.Text = "";
                    Contra.Text = "";
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

        private void Telefono_TextChanged(object sender, EventArgs e)
        {
            if (!Telefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("Favor de ingresar solo números.");
                Telefono.Text = null;
            }
            if(Telefono.Text.Length > 10)
            {
                MessageBox.Show("Favor de ingresar solo los 10 dígitos del número telefónico.");
                Telefono.Text = null;
            }
        }

        private void Sueldo_TextChanged(object sender, EventArgs e)
        {
            if (Sueldo.Text.Any(char.IsLetter) || Sueldo.Text.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("Favor de ingresar solo números o puntos decimales.");
                Sueldo.Text = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
            string nombre = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            string cargo = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            string estado = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
            string fecha = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value);
            string sueldo = Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value);
            string telefono = Convert.ToString(dataGridView1.SelectedRows[0].Cells[6].Value);
            string usuario = Convert.ToString(dataGridView1.SelectedRows[0].Cells[7].Value);
            string contra = Convert.ToString(dataGridView1.SelectedRows[0].Cells[8].Value);
            ID.Text = id;
            Nombre.Text = nombre;
            Cargo.Text = cargo;

            if (estado == "True")
                Estado.Text = "Activo";
            else if (estado == "False")
                Estado.Text = "Inactivo";

            Fecha.Text = fecha;
            Sueldo.Text = sueldo;
            Telefono.Text = telefono;
            Usuario.Text = usuario;
            Contra.Text = contra;
            Nombre.Enabled = false;
            Cargo.Enabled = false;
            Estado.Enabled = false;
            Fecha.Enabled = false;
            Sueldo.Enabled = false;
            Telefono.Enabled = false;
            Usuario.Enabled = false;
            Contra.Enabled = false;
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
            Cargo.Enabled = true;
            Estado.Enabled = true;
            Fecha.Enabled = true;
            Sueldo.Enabled = true;
            Telefono.Enabled = true;
            Usuario.Enabled = true;
            Contra.Enabled = true;
            Modificar.Enabled = false;
            mod = true;
        }


        private void EligeCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EligeCargo.Text == "Cualquiera" && EligeEstado.Text == "Cualquiera")
                dataGridView1.DataSource = Consultar();
            else if (EligeEstado.Text == "Cualquiera")
                dataGridView1.DataSource = ConsultaCargo(EligeCargo.Text);
            else if (EligeCargo.Text == "Cualquiera")
                dataGridView1.DataSource = ConsultaEstado(EligeEstado.Text);
            else
                dataGridView1.DataSource = ConsultaAmbos(EligeCargo.Text,EligeEstado.Text);
        }

        private void EligeEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EligeCargo.Text == "Cualquiera" && EligeEstado.Text == "Cualquiera")
                dataGridView1.DataSource = Consultar();
            else if (EligeEstado.Text == "Cualquiera")
                dataGridView1.DataSource = ConsultaCargo(EligeCargo.Text);
            else if (EligeCargo.Text == "Cualquiera")
                dataGridView1.DataSource = ConsultaEstado(EligeEstado.Text);
            else
                dataGridView1.DataSource = ConsultaAmbos(EligeCargo.Text, EligeEstado.Text);

        }
    }
}
