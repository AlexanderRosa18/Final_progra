using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUDD.Conexion;
namespace CRUDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            Producto = new Producto();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void editarButton_Click(object sender, EventArgs e)
        {

        }

        private void recuperarButton_Click(object sender, EventArgs e)
        {

        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
           
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
