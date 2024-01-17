
namespace Sistema_Veterinaria
{
    partial class MascotaM
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mascotaMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npgsqlConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ElegirDueno = new System.Windows.Forms.ComboBox();
            this.ElegirTelefono = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npgsqlConnectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 346);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Estado
            // 
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Estado.Location = new System.Drawing.Point(814, 474);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(280, 28);
            this.Estado.TabIndex = 49;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(814, 274);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(280, 27);
            this.Fecha.TabIndex = 47;
            this.Fecha.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(814, 224);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(280, 27);
            this.Nombre.TabIndex = 46;
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(814, 424);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(280, 27);
            this.Sueldo.TabIndex = 45;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(814, 324);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(280, 27);
            this.Telefono.TabIndex = 44;
            this.Telefono.TextChanged += new System.EventHandler(this.Telefono_TextChanged_1);
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(814, 174);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(280, 27);
            this.ID.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(729, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 28);
            this.label7.TabIndex = 42;
            this.label7.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(631, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nombre de dueño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(626, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "Número telefónico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(611, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 38;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(614, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre de mascota:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(771, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID:";
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
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(1046, 12);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(204, 50);
            this.Nuevo.TabIndex = 33;
            this.Nuevo.Text = "Registrar nueva mascota";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click_1);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(26, 123);
            this.Buscar.Name = "Buscar";
            this.Buscar.PlaceholderText = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(260, 27);
            this.Buscar.TabIndex = 32;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(710, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 41;
            this.label6.Text = "Dirección:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(814, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 27);
            this.textBox1.TabIndex = 51;
            // 
            // mascotaMBindingSource
            // 
            this.mascotaMBindingSource.DataSource = typeof(Sistema_Veterinaria.MascotaM);
            // 
            // npgsqlConnectionBindingSource
            // 
            this.npgsqlConnectionBindingSource.DataSource = typeof(Npgsql.NpgsqlConnection);
            // 
            // ElegirDueno
            // 
            this.ElegirDueno.FormattingEnabled = true;
            this.ElegirDueno.Items.AddRange(new object[] {
            "Cualquiera"});
            this.ElegirDueno.Location = new System.Drawing.Point(325, 122);
            this.ElegirDueno.Name = "ElegirDueno";
            this.ElegirDueno.Size = new System.Drawing.Size(124, 28);
            this.ElegirDueno.TabIndex = 54;
            this.ElegirDueno.Text = "Cualquiera";
            this.ElegirDueno.SelectedIndexChanged += new System.EventHandler(this.ElegirDueno_SelectedIndexChanged_1);
            // 
            // ElegirTelefono
            // 
            this.ElegirTelefono.FormattingEnabled = true;
            this.ElegirTelefono.Items.AddRange(new object[] {
            "Cualquiera"});
            this.ElegirTelefono.Location = new System.Drawing.Point(455, 122);
            this.ElegirTelefono.Name = "ElegirTelefono";
            this.ElegirTelefono.Size = new System.Drawing.Size(124, 28);
            this.ElegirTelefono.TabIndex = 55;
            this.ElegirTelefono.Text = "Cualquiera";
            this.ElegirTelefono.SelectedIndexChanged += new System.EventHandler(this.ElegirTelefono_SelectedIndexChanged_1);
            // 
            // MascotaM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.ElegirTelefono);
            this.Controls.Add(this.ElegirDueno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Sueldo);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MascotaM";
            this.Text = "a";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotaMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npgsqlConnectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Sueldo;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource mascotaMBindingSource;
        private System.Windows.Forms.BindingSource npgsqlConnectionBindingSource;
        private System.Windows.Forms.ComboBox ElegirDueno;
        private System.Windows.Forms.ComboBox ElegirTelefono;
    }
}