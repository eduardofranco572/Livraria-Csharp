using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Livraria
{
    public partial class excluir : Form
    {
        public excluir()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox5.Text);

            excluir2 confirmar = new excluir2(codigo);
            confirmar.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
