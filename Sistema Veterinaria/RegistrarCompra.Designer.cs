
namespace Sistema_Veterinaria
{
    partial class RegistrarCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Precio_producto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Importe = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Vaciar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.ID_Proveedor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.IVA = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ID_Producto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(334, 197);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(23, 68);
            this.Buscar.Name = "Buscar";
            this.Buscar.PlaceholderText = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(242, 27);
            this.Buscar.TabIndex = 28;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 41);
            this.label1.TabIndex = 29;
            this.label1.Text = "Elegir productos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(369, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre de producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(454, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(795, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID de compra: ";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(931, 82);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(64, 27);
            this.ID.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(388, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "Precio de producto:";
            // 
            // Precio_producto
            // 
            this.Precio_producto.Location = new System.Drawing.Point(578, 322);
            this.Precio_producto.Name = "Precio_producto";
            this.Precio_producto.Size = new System.Drawing.Size(125, 27);
            this.Precio_producto.TabIndex = 35;
            this.Precio_producto.TextChanged += new System.EventHandler(this.Precio_producto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(477, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(486, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 37;
            this.label7.Text = "Importe:";
            // 
            // Importe
            // 
            this.Importe.Enabled = false;
            this.Importe.Location = new System.Drawing.Point(578, 441);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(125, 27);
            this.Importe.TabIndex = 38;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(578, 381);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 27);
            this.numericUpDown1.TabIndex = 39;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(795, 205);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 4;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(444, 293);
            this.dataGridView2.TabIndex = 40;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 55.29601F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 267.3797F;
            this.Column2.HeaderText = "Producto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 133;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.FillWeight = 67.53266F;
            this.Column4.HeaderText = "Precio";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 49.78385F;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 76;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.FillWeight = 60.00783F;
            this.Column5.HeaderText = "Importe";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 99;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(578, 141);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(197, 58);
            this.Nombre.TabIndex = 41;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(578, 213);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(197, 85);
            this.Descripcion.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(795, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 41);
            this.label8.TabIndex = 43;
            this.label8.Text = "Detalles de la compra:";
            // 
            // Vaciar
            // 
            this.Vaciar.Location = new System.Drawing.Point(1120, 171);
            this.Vaciar.Name = "Vaciar";
            this.Vaciar.Size = new System.Drawing.Size(119, 27);
            this.Vaciar.TabIndex = 44;
            this.Vaciar.Text = "Vaciar tabla";
            this.Vaciar.UseVisualStyleBackColor = true;
            this.Vaciar.Click += new System.EventHandler(this.Vaciar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(1076, 560);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(163, 43);
            this.Guardar.TabIndex = 45;
            this.Guardar.Text = "Completar compra";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 46;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(23, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 41);
            this.label10.TabIndex = 48;
            this.label10.Text = "Elegir proveedor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Buscar";
            this.textBox1.Size = new System.Drawing.Size(242, 27);
            this.textBox1.TabIndex = 49;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(23, 394);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 4;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(334, 203);
            this.dataGridView3.TabIndex = 50;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1010, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 28);
            this.label9.TabIndex = 51;
            this.label9.Text = "ID de proveedor: ";
            // 
            // ID_Proveedor
            // 
            this.ID_Proveedor.Enabled = false;
            this.ID_Proveedor.Location = new System.Drawing.Point(1175, 81);
            this.ID_Proveedor.Name = "ID_Proveedor";
            this.ID_Proveedor.Size = new System.Drawing.Size(64, 27);
            this.ID_Proveedor.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(795, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 28);
            this.label11.TabIndex = 53;
            this.label11.Text = "Productos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(795, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Subtotal: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(795, 534);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "IVA:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(795, 558);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 28);
            this.label14.TabIndex = 56;
            this.label14.Text = "Total:";
            // 
            // Subtotal
            // 
            this.Subtotal.Location = new System.Drawing.Point(874, 510);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(143, 24);
            this.Subtotal.TabIndex = 57;
            // 
            // IVA
            // 
            this.IVA.Location = new System.Drawing.Point(874, 534);
            this.IVA.Name = "IVA";
            this.IVA.Size = new System.Drawing.Size(60, 20);
            this.IVA.TabIndex = 58;
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(874, 560);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(104, 26);
            this.Total.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(795, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 28);
            this.label15.TabIndex = 60;
            this.label15.Text = "Fecha:";
            // 
            // Fecha
            // 
            this.Fecha.Enabled = false;
            this.Fecha.Location = new System.Drawing.Point(867, 128);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(178, 27);
            this.Fecha.TabIndex = 61;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(423, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 28);
            this.label16.TabIndex = 62;
            this.label16.Text = "ID de producto:";
            // 
            // ID_Producto
            // 
            this.ID_Producto.Location = new System.Drawing.Point(578, 108);
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.Size = new System.Drawing.Size(196, 25);
            this.ID_Producto.TabIndex = 63;
            // 
            // RegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.ID_Producto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.IVA);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ID_Proveedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Vaciar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Precio_producto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarCompra";
            this.Text = "RegistrarCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Precio_producto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Importe;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Vaciar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ID_Proveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label IVA;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}