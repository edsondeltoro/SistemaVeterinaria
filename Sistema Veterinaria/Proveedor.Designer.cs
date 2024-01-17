
namespace Sistema_Veterinaria
{
    partial class Proveedor
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ElegirEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(423, 346);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(12, 99);
            this.Buscar.Name = "Buscar";
            this.Buscar.PlaceholderText = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(220, 27);
            this.Buscar.TabIndex = 27;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(713, 133);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(280, 27);
            this.ID.TabIndex = 28;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(713, 213);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(280, 27);
            this.Nombre.TabIndex = 29;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(713, 293);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(280, 27);
            this.Telefono.TabIndex = 30;
            this.Telefono.TextChanged += new System.EventHandler(this.Telefono_TextChanged);
            // 
            // Estado
            // 
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Estado.Location = new System.Drawing.Point(713, 451);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(280, 28);
            this.Estado.TabIndex = 31;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(713, 373);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(280, 27);
            this.Correo.TabIndex = 32;
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(1046, 12);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(204, 50);
            this.Nuevo.TabIndex = 33;
            this.Nuevo.Text = "Registrar nuevo proveedor";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click_1);
            // 
            // Modificar
            // 
            this.Modificar.Enabled = false;
            this.Modificar.Location = new System.Drawing.Point(764, 579);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(161, 48);
            this.Modificar.TabIndex = 34;
            this.Modificar.Text = "Modificar proveedor";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(1089, 579);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(161, 48);
            this.Guardar.TabIndex = 35;
            this.Guardar.Text = "Guardar cambios";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(672, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(494, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre de proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(527, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 38;
            this.label3.Text = "Número telefónico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(529, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "Correo electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(632, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(999, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Campo obligatorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(999, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Campo obligatorio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(999, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Campo obligatorio";
            // 
            // ElegirEstado
            // 
            this.ElegirEstado.FormattingEnabled = true;
            this.ElegirEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Cualquiera"});
            this.ElegirEstado.Location = new System.Drawing.Point(312, 99);
            this.ElegirEstado.Name = "ElegirEstado";
            this.ElegirEstado.Size = new System.Drawing.Size(123, 28);
            this.ElegirEstado.TabIndex = 45;
            this.ElegirEstado.Text = "Cualquiera";
            this.ElegirEstado.SelectedIndexChanged += new System.EventHandler(this.ElegirEstado_SelectedIndexChanged);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.ElegirEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ElegirEstado;
    }
}