using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" boton de aceptar", " Solicitud Aceptar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" botone de Cancelar", " ha sido Cancelado", MessageBoxButtons.OKCancel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" botones Sí o No, Cancelar", " Si o No, Cancelar", MessageBoxButtons.YesNoCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" boton Aceptar", " Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
