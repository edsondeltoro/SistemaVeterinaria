namespace Sistema_Veterinaria
{
    partial class Asistencia_cs
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
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id_empleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(58, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 28);
            this.label17.TabIndex = 101;
            this.label17.Text = "ID de empleado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1077, 159);
            this.label1.TabIndex = 102;
            this.label1.Text = "Registrar asistencia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 46);
            this.button1.TabIndex = 103;
            this.button1.Text = "Registra entrada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 46);
            this.button2.TabIndex = 104;
            this.button2.Text = "Registra salida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_empleado
            // 
            this.id_empleado.AutoSize = true;
            this.id_empleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_empleado.Location = new System.Drawing.Point(224, 230);
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Size = new System.Drawing.Size(0, 28);
            this.id_empleado.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(241, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 41);
            this.label2.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(241, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 41);
            this.label3.TabIndex = 107;
            // 
            // Asistencia_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 639);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_empleado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asistencia_cs";
            this.Text = "Asistencia_cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label id_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}