﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de realizar esta peticion de ayuda?                   ", " Confirmacion de ayuda", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show(" Muchas Gracias por tu solicitud                                                          "
                +
                   "           Peticion de ayuda enviada exitosamente!!!", " Computers Guevara.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
