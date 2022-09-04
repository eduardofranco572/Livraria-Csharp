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
    public partial class Alterar1 : Form
    {
        public Alterar1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox5.Text);

            Alterar3 confirmar = new Alterar3(codigo);
            confirmar.Show();
        }
    }
}
