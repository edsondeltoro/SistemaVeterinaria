
namespace Sistema_Veterinaria
{
    partial class Empleado
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
            this.Buscar = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Cargo = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.EligeEstado = new System.Windows.Forms.ComboBox();
            this.EligeCargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(12, 124);
            this.Buscar.Name = "Buscar";
            this.Buscar.PlaceholderText = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(260, 27);
            this.Buscar.TabIndex = 0;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(1046, 12);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(204, 50);
            this.Nuevo.TabIndex = 2;
            this.Nuevo.Text = "Registrar nuevo empleado";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Modificar
            // 
            this.Modificar.Enabled = false;
            this.Modificar.Location = new System.Drawing.Point(831, 579);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(161, 48);
            this.Modificar.TabIndex = 3;
            this.Modificar.Text = "Modificar empleado";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(1089, 579);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(161, 48);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar cambios";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(759, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(616, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(599, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(614, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Número telefónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(725, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(717, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sueldo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(719, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(800, 132);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(280, 27);
            this.ID.TabIndex = 13;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(800, 282);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(280, 27);
            this.Telefono.TabIndex = 14;
            this.Telefono.TextChanged += new System.EventHandler(this.Telefono_TextChanged);
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(800, 382);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(280, 27);
            this.Sueldo.TabIndex = 15;
            this.Sueldo.TextChanged += new System.EventHandler(this.Sueldo_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(800, 182);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(280, 27);
            this.Nombre.TabIndex = 19;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(800, 232);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(280, 27);
            this.Fecha.TabIndex = 20;
            this.Fecha.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // Cargo
            // 
            this.Cargo.FormattingEnabled = true;
            this.Cargo.Items.AddRange(new object[] {
            "Mostrador",
            "Asistente",
            "Intendente"});
            this.Cargo.Location = new System.Drawing.Point(800, 332);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(280, 28);
            this.Cargo.TabIndex = 23;
            // 
            // Estado
            // 
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Estado.Location = new System.Drawing.Point(800, 432);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(280, 28);
            this.Estado.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 401);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1086, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Campo obligatorio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1086, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Campo obligatorio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1086, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Campo obligatorio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1086, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Campo obligatorio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1086, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Campo obligatorio";
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(800, 482);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(280, 27);
            this.Usuario.TabIndex = 32;
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(800, 532);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(280, 27);
            this.Contra.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1086, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Campo obligatorio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1086, 539);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Campo obligatorio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(715, 481);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 28);
            this.label15.TabIndex = 36;
            this.label15.Text = "Usuario";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(684, 531);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 28);
            this.label16.TabIndex = 37;
            this.label16.Text = "Contraseña";
            // 
            // EligeEstado
            // 
            this.EligeEstado.FormattingEnabled = true;
            this.EligeEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Cualquiera"});
            this.EligeEstado.Location = new System.Drawing.Point(442, 124);
            this.EligeEstado.Name = "EligeEstado";
            this.EligeEstado.Size = new System.Drawing.Size(123, 28);
            this.EligeEstado.TabIndex = 38;
            this.EligeEstado.Text = "Cualquiera";
            this.EligeEstado.SelectedIndexChanged += new System.EventHandler(this.EligeEstado_SelectedIndexChanged);
            // 
            // EligeCargo
            // 
            this.EligeCargo.FormattingEnabled = true;
            this.EligeCargo.Items.AddRange(new object[] {
            "Veterinario",
            "Mostrador",
            "Asitente",
            "Intendente",
            "Cualquiera"});
            this.EligeCargo.Location = new System.Drawing.Point(313, 124);
            this.EligeCargo.Name = "EligeCargo";
            this.EligeCargo.Size = new System.Drawing.Size(123, 28);
            this.EligeCargo.TabIndex = 39;
            this.EligeCargo.Text = "Cualquiera";
            this.EligeCargo.SelectedIndexChanged += new System.EventHandler(this.EligeCargo_SelectedIndexChanged);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.EligeCargo);
            this.Controls.Add(this.EligeEstado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Cargo);
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
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Sueldo;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.ComboBox Cargo;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox EligeEstado;
        private System.Windows.Forms.ComboBox EligeCargo;
    }
}