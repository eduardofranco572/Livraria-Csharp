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
    public partial class excluir2 : Form
    {
        public int ID;
        public excluir2(int code)
        {
            InitializeComponent();

         
        }

        private void button1_Click(object sender, EventArgs e, int code)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            excluir excluir = new excluir();
            excluir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=cadastro_livro; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand deletar = new MySqlCommand();

            deletar.Connection = conectar;

            deletar.CommandText = "delete from cadastros where codigo =  " + ID;

            dataGridView1.Rows.Clear();

            MySqlDataReader Resultado = deletar.ExecuteReader();

            MessageBox.Show("Dados Excluidos com Sucesso!!!");
        }
    }
}
