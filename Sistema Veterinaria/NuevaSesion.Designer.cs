
namespace Sistema_Veterinaria
{
    partial class NuevaSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contrasenna = new System.Windows.Forms.TextBox();
            this.Inicio = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido! Favor de iniciar sesión:";
            // 
            // Usuario
            // 
            this.Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Usuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Usuario.Location = new System.Drawing.Point(90, 158);
            this.Usuario.Name = "Usuario";
            this.Usuario.PlaceholderText = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(240, 27);
            this.Usuario.TabIndex = 1;
            // 
            // Contrasenna
            // 
            this.Contrasenna.Location = new System.Drawing.Point(90, 271);
            this.Contrasenna.Name = "Contrasenna";
            this.Contrasenna.PasswordChar = '*';
            this.Contrasenna.PlaceholderText = "Contraseña";
            this.Contrasenna.Size = new System.Drawing.Size(240, 27);
            this.Contrasenna.TabIndex = 2;
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inicio.Location = new System.Drawing.Point(290, 376);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(111, 29);
            this.Inicio.TabIndex = 3;
            this.Inicio.Text = "Continuar";
            this.Inicio.UseVisualStyleBackColor = false;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Location = new System.Drawing.Point(12, 376);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(111, 29);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // NuevaSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(413, 417);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.Contrasenna);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Contrasenna;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Salir;
    }
}