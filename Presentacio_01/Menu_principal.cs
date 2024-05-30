using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacio_01
{
    public partial class Menu_principal : Form
    {
        private Button btnFacturas;
        private Button btnInventario;
        private Button btnClientes;
        private Button btnsalir;
        public Menu_principal()
        {
            InitializeComponent();
        }
        private void InitializeComponents()
        {
            // Initialize controls
            btnFacturas = new Button { Text = "Facturas", Top = 10, Left = 10, Width = 100 };
            btnInventario = new Button { Text = "Inventario", Top = 40, Left = 10, Width = 100 };
            btnClientes = new Button { Text = "Clientes", Top = 70, Left = 10, Width = 100 };
            btnsalir = new Button { Text ="salir", Top = 70, Left = 10, Width = 100 };
            // Add event handlers
            btnFacturas.Click += btn_factura_Click;
            btnInventario.Click += btn_inventario_Click;
            btnClientes.Click += btn_cliente_Click;
            btnsalir.Click +=btn_salir_Click;

            // Add controls to the form
            Controls.Add(btnFacturas);
            Controls.Add(btnInventario);
            Controls.Add(btnClientes);
            Controls.Add(btnsalir);
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Deseas salir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text=DateTime.Now.ToShortTimeString();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            Form facturaForm = new Factura();
            facturaForm.Show();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Form facturaForm = new Cliente();
            facturaForm.Show();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Form facturaForm = new Inventario();
            facturaForm.Show();
        }

        public static class Program
        {
            [STAThread]
            public static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Menu_principal());
            }
        }
    }
}
