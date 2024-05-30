namespace Presentacio_01
{
    partial class Inventario
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
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_mostar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_busqueda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_inventario = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(806, 46);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_mostar
            // 
            this.btn_mostar.Location = new System.Drawing.Point(713, 46);
            this.btn_mostar.Name = "btn_mostar";
            this.btn_mostar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostar.TabIndex = 12;
            this.btn_mostar.Text = "Mostrar";
            this.btn_mostar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_busqueda);
            this.groupBox2.Location = new System.Drawing.Point(366, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 48);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda ";
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.Location = new System.Drawing.Point(32, 19);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(75, 23);
            this.btn_busqueda.TabIndex = 0;
            this.btn_busqueda.Text = "Buscar";
            this.btn_busqueda.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Location = new System.Drawing.Point(34, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 69);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Producto por nombre";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(8, 28);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(283, 20);
            this.txt_buscar.TabIndex = 0;
            // 
            // dgv_inventario
            // 
            this.dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventario.Location = new System.Drawing.Point(34, 124);
            this.dgv_inventario.Name = "dgv_inventario";
            this.dgv_inventario.Size = new System.Drawing.Size(871, 305);
            this.dgv_inventario.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-26, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 20);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 20);
            this.panel1.TabIndex = 7;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_mostar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_inventario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_mostar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_busqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_inventario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}