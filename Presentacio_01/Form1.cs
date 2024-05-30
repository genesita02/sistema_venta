using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Presentacio_01
{
    public partial class Form1 : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private UserService userService = new UserService();
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponents()
        {
            // Initialize text boxes
            txt_usuario = new TextBox { Text = "nombre", Top = 10, Left = 10, Width = 200 };
            txt_contraseña = new TextBox { Text = "codigo_usuario", UseSystemPasswordChar = true, Top = 40, Left = 10, Width = 200 };

            // Initialize login button
            btn_ingrsar = new Button { Text = "Login", Top = 70, Left = 10 };
            btnLogin.Click += btn_ingrsar_Click;

            // Initialize exit button
            btn_salir = new Button { Text = "Exit", Top = 70, Left = 100 };
            btnExit.Click +=  btn_salir_Click;

            // Add controls to the form
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);

        }

        private void btn_ingrsar_Click(object sender, EventArgs e)
        {
            string nombre = txt_usuario.Text;
            string codigo_usuario = txt_contraseña.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(codigo_usuario))
            {
                MessageBox.Show("Porfavor Ingresar su nombre de usuario y contraseña.");
                return;
            }

            bool isValid = userService.ValidateUser(nombre, codigo_usuario);
            if (isValid)
            {
                MessageBox.Show("!Bienvenido de nuevo¡");
                Form formulario = new Menu_principal();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Su nombre de usuario o la contraseña son incorrectos");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Te vas tan pronto?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
