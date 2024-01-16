
namespace Sistema_Veterinaria
{
    partial class Producto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.Detalles = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Precio_venta = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 381);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(12, 83);
            this.Buscar.Name = "Buscar";
            this.Buscar.PlaceholderText = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(260, 27);
            this.Buscar.TabIndex = 27;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(1046, 12);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(204, 50);
            this.Nuevo.TabIndex = 28;
            this.Nuevo.Text = "Registrar nuevo producto";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Modificar
            // 
            this.Modificar.Enabled = false;
            this.Modificar.Location = new System.Drawing.Point(817, 579);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(161, 48);
            this.Modificar.TabIndex = 29;
            this.Modificar.Text = "Modificar producto";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(1089, 579);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(161, 48);
            this.Guardar.TabIndex = 30;
            this.Guardar.Text = "Guardar cambios";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click_1);
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(790, 132);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(280, 27);
            this.ID.TabIndex = 31;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(790, 182);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(280, 27);
            this.Nombre.TabIndex = 32;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(756, 232);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(139, 27);
            this.Precio.TabIndex = 33;
            this.Precio.TextChanged += new System.EventHandler(this.Precio_TextChanged);
            // 
            // Estado
            // 
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Estado.Location = new System.Drawing.Point(790, 528);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(280, 28);
            this.Estado.TabIndex = 34;
            // 
            // Detalles
            // 
            this.Detalles.Location = new System.Drawing.Point(790, 332);
            this.Detalles.Multiline = true;
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(377, 174);
            this.Detalles.TabIndex = 35;
            // 
            // Cantidad
            // 
            this.Cantidad.Enabled = false;
            this.Cantidad.Location = new System.Drawing.Point(790, 282);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(280, 27);
            this.Cantidad.TabIndex = 36;
            this.Cantidad.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(635, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID de producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(581, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre de producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(581, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 39;
            this.label3.Text = "Precio de compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(720, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 40;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(709, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(666, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(901, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 43;
            this.label7.Text = "Precio de venta:";
            // 
            // Precio_venta
            // 
            this.Precio_venta.Location = new System.Drawing.Point(1057, 233);
            this.Precio_venta.Name = "Precio_venta";
            this.Precio_venta.Size = new System.Drawing.Size(139, 27);
            this.Precio_venta.TabIndex = 44;
            this.Precio_venta.TextChanged += new System.EventHandler(this.Precio_venta_TextChanged);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.Precio_venta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Guardar;
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