namespace Presentacio_01
{
    partial class Factura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_itbs_02 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_itbis = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_sub_total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_factura = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_atua = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rnc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_nom_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_num_recibo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_num_identidad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factura)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_num_identidad);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbx_estado);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.dgv_factura);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_nom_cliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_id_cliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_num_recibo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1149, 549);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturacion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "Estado";
            // 
            // cbx_estado
            // 
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Pendiente"});
            this.cbx_estado.Location = new System.Drawing.Point(110, 177);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(121, 21);
            this.cbx_estado.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_total);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_itbs_02);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_itbis);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_sub_total);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(655, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 113);
            this.panel2.TabIndex = 12;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(78, 78);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 14);
            this.label14.TabIndex = 6;
            this.label14.Text = "Total";
            // 
            // txt_itbs_02
            // 
            this.txt_itbs_02.Location = new System.Drawing.Point(160, 45);
            this.txt_itbs_02.Name = "txt_itbs_02";
            this.txt_itbs_02.Size = new System.Drawing.Size(37, 20);
            this.txt_itbs_02.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(131, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 14);
            this.label13.TabIndex = 4;
            this.label13.Text = "%";
            // 
            // txt_itbis
            // 
            this.txt_itbis.Location = new System.Drawing.Point(78, 45);
            this.txt_itbis.Name = "txt_itbis";
            this.txt_itbis.Size = new System.Drawing.Size(45, 20);
            this.txt_itbis.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 14);
            this.label12.TabIndex = 2;
            this.label12.Text = "Itbs";
            // 
            // txt_sub_total
            // 
            this.txt_sub_total.Location = new System.Drawing.Point(78, 12);
            this.txt_sub_total.Name = "txt_sub_total";
            this.txt_sub_total.Size = new System.Drawing.Size(100, 20);
            this.txt_sub_total.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sub Total";
            // 
            // dgv_factura
            // 
            this.dgv_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_factura.Location = new System.Drawing.Point(655, 121);
            this.dgv_factura.Name = "dgv_factura";
            this.dgv_factura.Size = new System.Drawing.Size(488, 150);
            this.dgv_factura.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(676, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 45);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Buscar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_atua);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(550, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 179);
            this.panel1.TabIndex = 9;
            // 
            // btn_atua
            // 
            this.btn_atua.Location = new System.Drawing.Point(15, 140);
            this.btn_atua.Name = "btn_atua";
            this.btn_atua.Size = new System.Drawing.Size(75, 23);
            this.btn_atua.TabIndex = 3;
            this.btn_atua.Text = "Actualizar";
            this.btn_atua.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(15, 102);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(15, 60);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(15, 23);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_codigo);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_descrip);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_rnc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_precio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_producto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Location = new System.Drawing.Point(9, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 156);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Producto";
            // 
            // txt_descrip
            // 
            this.txt_descrip.Location = new System.Drawing.Point(357, 130);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(100, 20);
            this.txt_descrip.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Descripcion";
            // 
            // txt_rnc
            // 
            this.txt_rnc.Location = new System.Drawing.Point(357, 86);
            this.txt_rnc.Name = "txt_rnc";
            this.txt_rnc.Size = new System.Drawing.Size(100, 20);
            this.txt_rnc.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "RNC";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(155, 124);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(67, 20);
            this.txt_cantidad.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cantidad";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(155, 86);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(67, 20);
            this.txt_precio.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Precio";
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(88, 21);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(369, 20);
            this.txt_producto.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Producto";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(541, 24);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txt_nom_cliente
            // 
            this.txt_nom_cliente.Location = new System.Drawing.Point(153, 124);
            this.txt_nom_cliente.Name = "txt_nom_cliente";
            this.txt_nom_cliente.Size = new System.Drawing.Size(246, 20);
            this.txt_nom_cliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre de cliente";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(113, 86);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(51, 20);
            this.txt_id_cliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID cliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // txt_num_recibo
            // 
            this.txt_num_recibo.Location = new System.Drawing.Point(40, 20);
            this.txt_num_recibo.Name = "txt_num_recibo";
            this.txt_num_recibo.Size = new System.Drawing.Size(55, 20);
            this.txt_num_recibo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NO.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.ForeColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(1, 608);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1161, 19);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(1, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1213, 22);
            this.panel4.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 18);
            this.label16.TabIndex = 14;
            this.label16.Text = "Numero de identidad";
            // 
            // txt_num_identidad
            // 
            this.txt_num_identidad.Location = new System.Drawing.Point(177, 215);
            this.txt_num_identidad.Name = "txt_num_identidad";
            this.txt_num_identidad.Size = new System.Drawing.Size(210, 20);
            this.txt_num_identidad.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 14);
            this.label17.TabIndex = 11;
            this.label17.Text = "Codigo";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(88, 52);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 12;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 626);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factura)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_itbs_02;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_itbis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_sub_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_factura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_atua;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_rnc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_nom_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_num_recibo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.TextBox txt_num_identidad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_codigo;
    }
}