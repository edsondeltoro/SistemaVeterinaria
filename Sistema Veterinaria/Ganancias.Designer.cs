
namespace Sistema_Veterinaria
{
    partial class Ganancias
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
            this.Total = new System.Windows.Forms.Label();
            this.Id_empleado = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Id_venta = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_mascota = new System.Windows.Forms.Label();
            this.Nombre_m = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Citas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(1098, 573);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(124, 35);
            this.Total.TabIndex = 97;
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
            this.Citas,
            this.Ventas,
            this.Empleados,
            this.Compras});
            this.dataGridView1.Location = new System.Drawing.Point(41, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(730, 74);
            this.dataGridView1.TabIndex = 83;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 27);
            this.dateTimePicker1.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 110;
            this.label1.Text = "Selecciona fecha de inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 28);
            this.label2.TabIndex = 111;
            this.label2.Text = "Selecciona fecha de cierre: ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(291, 160);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(274, 27);
            this.dateTimePicker2.TabIndex = 112;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 83);
            this.button1.TabIndex = 113;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 81);
            this.label3.TabIndex = 114;
            // 
            // Citas
            // 
            this.Citas.HeaderText = "Citas";
            this.Citas.MinimumWidth = 6;
            this.Citas.Name = "Citas";
            this.Citas.ReadOnly = true;
            // 
            // Ventas
            // 
            this.Ventas.HeaderText = "Ventas";
            this.Ventas.MinimumWidth = 6;
            this.Ventas.Name = "Ventas";
            this.Ventas.ReadOnly = true;
            // 
            // Empleados
            // 
            this.Empleados.HeaderText = "Empleados";
            this.Empleados.MinimumWidth = 6;
            this.Empleados.Name = "Empleados";
            this.Empleados.ReadOnly = true;
            // 
            // Compras
            // 
            this.Compras.HeaderText = "Compras";
            this.Compras.MinimumWidth = 6;
            this.Compras.Name = "Compras";
            this.Compras.ReadOnly = true;
            // 
            // Ganancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Nombre_m);
            this.Controls.Add(this.Id_mascota);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Id_empleado);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Id_venta);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ganancias";
            this.Text = "ra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Id_empleado;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Id_venta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Id_mascota;
        private System.Windows.Forms.Label Nombre_m;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Citas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compras;
    }
}