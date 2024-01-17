
namespace Sistema_Veterinaria
{
    partial class Mostrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cierreSesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cierreSesion);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 34);
            this.panel1.TabIndex = 0;
            // 
            // cierreSesion
            // 
            this.cierreSesion.BackColor = System.Drawing.SystemColors.Highlight;
            this.cierreSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cierreSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.cierreSesion.Location = new System.Drawing.Point(1086, 0);
            this.cierreSesion.Name = "cierreSesion";
            this.cierreSesion.Size = new System.Drawing.Size(120, 34);
            this.cierreSesion.TabIndex = 2;
            this.cierreSesion.Text = "Cerrar sesión";
            this.cierreSesion.UseVisualStyleBackColor = false;
            this.cierreSesion.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1206, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem,
            this.mascotaToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.compraToolStripMenuItem,
            this.ventaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(89, 30);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            this.asistenciaToolStripMenuItem.Click += new System.EventHandler(this.asistenciaToolStripMenuItem_Click);
            // 
            // mascotaToolStripMenuItem
            // 
            this.mascotaToolStripMenuItem.Name = "mascotaToolStripMenuItem";
            this.mascotaToolStripMenuItem.Size = new System.Drawing.Size(79, 30);
            this.mascotaToolStripMenuItem.Text = "Mascota";
            this.mascotaToolStripMenuItem.Click += new System.EventHandler(this.mascotaToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.compraToolStripMenuItem.Text = "Consultar compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.consultarVentaToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(60, 30);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // consultarVentaToolStripMenuItem
            // 
            this.consultarVentaToolStripMenuItem.Name = "consultarVentaToolStripMenuItem";
            this.consultarVentaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.consultarVentaToolStripMenuItem.Text = "Consultar Venta";
            this.consultarVentaToolStripMenuItem.Click += new System.EventHandler(this.consultarVentaToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 639);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(377, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido!\r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(937, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cambiar contraseña";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Mostrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mostrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVentaToolStripMenuItem;
        private System.Windows.Forms.Button cierreSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}