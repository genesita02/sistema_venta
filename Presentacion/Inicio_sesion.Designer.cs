namespace Presentacion
{
    partial class Inicio_sesion
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
            this.cbx_rol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ingrsar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_rol
            // 
            this.cbx_rol.FormattingEnabled = true;
            this.cbx_rol.Items.AddRange(new object[] {
            "Administrador de la tienda",
            "Representante de servicio al cliente",
            "Editor de contenido",
            "Especialista en marketing",
            "Desarrollador web"});
            this.cbx_rol.Location = new System.Drawing.Point(202, 103);
            this.cbx_rol.Name = "cbx_rol";
            this.cbx_rol.Size = new System.Drawing.Size(121, 21);
            this.cbx_rol.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(42, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rol de usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 60);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 51);
            this.panel1.TabIndex = 23;
            // 
            // btn_ingrsar
            // 
            this.btn_ingrsar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ingrsar.ForeColor = System.Drawing.Color.Black;
            this.btn_ingrsar.Location = new System.Drawing.Point(285, 318);
            this.btn_ingrsar.Name = "btn_ingrsar";
            this.btn_ingrsar.Size = new System.Drawing.Size(105, 23);
            this.btn_ingrsar.TabIndex = 21;
            this.btn_ingrsar.Text = "Ingresar";
            this.btn_ingrsar.UseVisualStyleBackColor = false;
            this.btn_ingrsar.Click += new System.EventHandler(this.btn_ingrsar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salir.Location = new System.Drawing.Point(407, 318);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(105, 23);
            this.btn_salir.TabIndex = 22;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(199, 180);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(191, 20);
            this.txt_usuario.TabIndex = 19;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(199, 262);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(191, 20);
            this.txt_contraseña.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(42, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(42, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuario";
            // 
            // Inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 407);
            this.Controls.Add(this.cbx_rol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ingrsar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inicio_sesion";
            this.Text = "Inicio_sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_rol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ingrsar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}