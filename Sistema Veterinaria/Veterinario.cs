using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Veterinaria
{
    public partial class Veterinario : Form
    {
        public Veterinario()
        {
            InitializeComponent();
        }

        public void AbrirPanel(Form F)
        {
            if (panel2.Controls.Count > 0)
                panel2.Controls.RemoveAt(0);
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            panel2.Controls.Add(F);
            panel2.Tag = F;
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Empleado());
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Proveedor());
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Producto());
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new RegistrarCompra());
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new RegistrarVenta());
        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Mascota());
        }

        private void consultarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new ConsultarCompra());
        }

        private void consultarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new ConsultarVenta());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new NuevaSesion();
            a.Show();
            this.Hide();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Citas());
        }

        private void gananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Ganancias());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
