
namespace Sistema_Veterinaria
{
    partial class Citas
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
            this.Nombre_e = new System.Windows.Forms.Label();
            this.IVA = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.Id_empleado = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Id_venta = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_mascota = new System.Windows.Forms.Label();
            this.Nombre_m = new System.Windows.Forms.Label();
            this.Fecha_c = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.ElegirMascota = new System.Windows.Forms.ComboBox();
            this.ElegirEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Detalles = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.IdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre_e
            // 
            this.Nombre_e.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombre_e.Location = new System.Drawing.Point(582, 85);
            this.Nombre_e.Name = "Nombre_e";
            this.Nombre_e.Size = new System.Drawing.Size(295, 35);
            this.Nombre_e.TabIndex = 100;
            // 
            // IVA
            // 
            this.IVA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IVA.Location = new System.Drawing.Point(937, 573);
            this.IVA.Name = "IVA";
            this.IVA.Size = new System.Drawing.Size(91, 35);
            this.IVA.TabIndex = 98;
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(1098, 573);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(124, 35);
            this.Total.TabIndex = 97;
            // 
            // Subtotal
            // 
            this.Subtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtotal.Location = new System.Drawing.Point(756, 573);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(124, 36);
            this.Subtotal.TabIndex = 96;
            // 
            // Id_empleado
            // 
            this.Id_empleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id_empleado.Location = new System.Drawing.Point(582, 30);
            this.Id_empleado.Name = "Id_empleado";
            this.Id_empleado.Size = new System.Drawing.Size(123, 35);
            this.Id_empleado.TabIndex = 95;
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fecha.Location = new System.Drawing.Point(526, 30);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(148, 35);
            this.Fecha.TabIndex = 94;
            // 
            // Id_venta
            // 
            this.Id_venta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id_venta.Location = new System.Drawing.Point(162, 30);
            this.Id_venta.Name = "Id_venta";
            this.Id_venta.Size = new System.Drawing.Size(148, 35);
            this.Id_venta.TabIndex = 93;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCita,
            this.Mascota,
            this.Fecha2,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(41, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(563, 365);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Id_mascota
            // 
            this.Id_mascota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id_mascota.Location = new System.Drawing.Point(1083, 30);
            this.Id_mascota.Name = "Id_mascota";
            this.Id_mascota.Size = new System.Drawing.Size(123, 35);
            this.Id_mascota.TabIndex = 103;
            // 
            // Nombre_m
            // 
            this.Nombre_m.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombre_m.Location = new System.Drawing.Point(1083, 85);
            this.Nombre_m.Name = "Nombre_m";
            this.Nombre_m.Size = new System.Drawing.Size(123, 35);
            this.Nombre_m.TabIndex = 104;
            // 
            // Fecha_c
            // 
            this.Fecha_c.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fecha_c.Location = new System.Drawing.Point(213, 85);
            this.Fecha_c.Name = "Fecha_c";
            this.Fecha_c.Size = new System.Drawing.Size(148, 35);
            this.Fecha_c.TabIndex = 105;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 27);
            this.dateTimePicker1.TabIndex = 109;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 27);
            this.button1.TabIndex = 110;
            this.button1.Text = "Cualquier fecha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElegirMascota
            // 
            this.ElegirMascota.FormattingEnabled = true;
            this.ElegirMascota.Location = new System.Drawing.Point(187, 93);
            this.ElegirMascota.Name = "ElegirMascota";
            this.ElegirMascota.Size = new System.Drawing.Size(135, 28);
            this.ElegirMascota.TabIndex = 111;
            this.ElegirMascota.Text = "Cualquiera";
            this.ElegirMascota.SelectedIndexChanged += new System.EventHandler(this.ElegirMascota_SelectedIndexChanged_1);
            // 
            // ElegirEmpleado
            // 
            this.ElegirEmpleado.FormattingEnabled = true;
            this.ElegirEmpleado.Items.AddRange(new object[] {
            "Cualquiera",
            "Pendiente",
            "Completada"});
            this.ElegirEmpleado.Location = new System.Drawing.Point(469, 93);
            this.ElegirEmpleado.Name = "ElegirEmpleado";
            this.ElegirEmpleado.Size = new System.Drawing.Size(135, 28);
            this.ElegirEmpleado.TabIndex = 112;
            this.ElegirEmpleado.Text = "Cualquiera";
            this.ElegirEmpleado.SelectedIndexChanged += new System.EventHandler(this.ElegirEmpleado_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(769, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 113;
            this.label1.Text = "ID:";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(810, 128);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(280, 27);
            this.ID.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(714, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 115;
            this.label2.Text = "Mascota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(675, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 117;
            this.label3.Text = "Fecha de cita:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(810, 207);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(280, 27);
            this.dateTimePicker2.TabIndex = 118;
            this.dateTimePicker2.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(682, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 119;
            this.label4.Text = "Hora de cita:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30"});
            this.comboBox1.Location = new System.Drawing.Point(810, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(73, 28);
            this.comboBox1.TabIndex = 120;
            this.comboBox1.Text = "Elegir";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(810, 169);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(280, 28);
            this.comboBox2.TabIndex = 121;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(644, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 28);
            this.label17.TabIndex = 122;
            this.label17.Text = "ID de empleado: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(810, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 27);
            this.textBox1.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(686, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 124;
            this.label5.Text = "Descripción:";
            // 
            // Detalles
            // 
            this.Detalles.Location = new System.Drawing.Point(810, 298);
            this.Detalles.Multiline = true;
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(280, 194);
            this.Detalles.TabIndex = 125;
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(1046, 12);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(204, 50);
            this.Nuevo.TabIndex = 126;
            this.Nuevo.Text = "Registrar nueva cita";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Modificar
            // 
            this.Modificar.Enabled = false;
            this.Modificar.Location = new System.Drawing.Point(867, 579);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(161, 48);
            this.Modificar.TabIndex = 127;
            this.Modificar.Text = "Modificar cita";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(1089, 579);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(161, 48);
            this.Guardar.TabIndex = 128;
            this.Guardar.Text = "Guardar cambios";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(889, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 129;
            this.label6.Text = "Estado:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Pendiente",
            "Completada"});
            this.comboBox3.Location = new System.Drawing.Point(970, 250);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(120, 28);
            this.comboBox3.TabIndex = 130;
            this.comboBox3.Text = "Pendiente";
            // 
            // IdCita
            // 
            this.IdCita.HeaderText = "ID cita";
            this.IdCita.MinimumWidth = 6;
            this.IdCita.Name = "IdCita";
            this.IdCita.ReadOnly = true;
            // 
            // Mascota
            // 
            this.Mascota.HeaderText = "Mascota";
            this.Mascota.MinimumWidth = 6;
            this.Mascota.Name = "Mascota";
            this.Mascota.ReadOnly = true;
            // 
            // Fecha2
            // 
            this.Fecha2.HeaderText = "Fecha";
            this.Fecha2.MinimumWidth = 6;
            this.Fecha2.Name = "Fecha2";
            this.Fecha2.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ElegirEmpleado);
            this.Controls.Add(this.ElegirMascota);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Fecha_c);
            this.Controls.Add(this.Nombre_m);
            this.Controls.Add(this.Id_mascota);
            this.Controls.Add(this.Nombre_e);
            this.Controls.Add(this.IVA);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.Id_empleado);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Id_venta);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre_e;
        private System.Windows.Forms.Label IVA;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label Id_empleado;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Id_venta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Id_mascota;
        private System.Windows.Forms.Label Nombre_m;
        private System.Windows.Forms.Label Fecha_c;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ElegirMascota;
        private System.Windows.Forms.ComboBox ElegirEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Detalles;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}