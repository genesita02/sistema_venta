﻿using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentacio_01
{
    public partial class Inventario : Form
    {
        
        public Inventario()
        {
            InitializeComponent();
            LoadInventory();

            
        }
        

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
