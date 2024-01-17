﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Veterinaria
{
    public partial class Mostrador : Form
    {
        public Mostrador()
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

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new ProductoM());
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new RegistrarVentaM());
        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MascotaM());
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

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new ConsultarCompra());
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Asistencia_cs());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirPanel(new Contra());
        }
    }
}
