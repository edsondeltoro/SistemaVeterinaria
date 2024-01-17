
namespace Sistema_Veterinaria
{
    partial class ProductoM
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
            dataGridView1 = new DataGridView();
            Buscar = new TextBox();
            ID = new TextBox();
            Nombre = new TextBox();
            Precio = new TextBox();
            Estado = new ComboBox();
            Detalles = new TextBox();
            Cantidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Precio_venta = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 94);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(484, 286);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Buscar
            // 
            Buscar.Location = new Point(10, 62);
            Buscar.Margin = new Padding(3, 2, 3, 2);
            Buscar.Name = "Buscar";
            Buscar.PlaceholderText = "Buscar";
            Buscar.Size = new Size(228, 23);
            Buscar.TabIndex = 27;
            Buscar.TextChanged += Buscar_TextChanged;
            // 
            // ID
            // 
            ID.Enabled = false;
            ID.Location = new Point(691, 99);
            ID.Margin = new Padding(3, 2, 3, 2);
            ID.Name = "ID";
            ID.Size = new Size(246, 23);
            ID.TabIndex = 31;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(691, 136);
            Nombre.Margin = new Padding(3, 2, 3, 2);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(246, 23);
            Nombre.TabIndex = 32;
            // 
            // Precio
            // 
            Precio.Location = new Point(662, 174);
            Precio.Margin = new Padding(3, 2, 3, 2);
            Precio.Name = "Precio";
            Precio.Size = new Size(122, 23);
            Precio.TabIndex = 33;
            Precio.TextChanged += Precio_TextChanged;
            // 
            // Estado
            // 
            Estado.FormattingEnabled = true;
            Estado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            Estado.Location = new Point(691, 396);
            Estado.Margin = new Padding(3, 2, 3, 2);
            Estado.Name = "Estado";
            Estado.Size = new Size(246, 23);
            Estado.TabIndex = 34;
            Estado.SelectedIndexChanged += Estado_SelectedIndexChanged;
            // 
            // Detalles
            // 
            Detalles.Location = new Point(691, 249);
            Detalles.Margin = new Padding(3, 2, 3, 2);
            Detalles.Multiline = true;
            Detalles.Name = "Detalles";
            Detalles.Size = new Size(330, 132);
            Detalles.TabIndex = 35;
            Detalles.TextChanged += Detalles_TextChanged;
            // 
            // Cantidad
            // 
            Cantidad.Enabled = false;
            Cantidad.Location = new Point(691, 212);
            Cantidad.Margin = new Padding(3, 2, 3, 2);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(246, 23);
            Cantidad.TabIndex = 36;
            Cantidad.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(556, 99);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 37;
            label1.Text = "ID de producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(508, 136);
            label2.Name = "label2";
            label2.Size = new Size(159, 21);
            label2.TabIndex = 38;
            label2.Text = "Nombre de producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(508, 174);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 39;
            label3.Text = "Precio de compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(630, 212);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 40;
            label4.Text = "Stock:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(620, 396);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 41;
            label5.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(583, 249);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 42;
            label6.Text = "Descripción:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(788, 174);
            label7.Name = "label7";
            label7.Size = new Size(119, 21);
            label7.TabIndex = 43;
            label7.Text = "Precio de venta:";
            // 
            // Precio_venta
            // 
            Precio_venta.Location = new Point(925, 175);
            Precio_venta.Margin = new Padding(3, 2, 3, 2);
            Precio_venta.Name = "Precio_venta";
            Precio_venta.Size = new Size(122, 23);
            Precio_venta.TabIndex = 44;
            Precio_venta.TextChanged += Precio_venta_TextChanged;
            // 
            // ProductoM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 479);
            Controls.Add(Precio_venta);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cantidad);
            Controls.Add(Detalles);
            Controls.Add(Estado);
            Controls.Add(Precio);
            Controls.Add(Nombre);
            Controls.Add(ID);
            Controls.Add(Buscar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductoM";
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.TextBox Detalles;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Precio_venta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}