using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroDosLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro cadastrar = new cadastro();
            cadastrar.Show();
        }

        private void pesquisarUmLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisa pesquisar = new pesquisa();
            pesquisar.Show();
        }

        private void excluirUmLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluir excluir = new excluir();
            excluir.Show();
        }

        private void editarUmLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar1 editar = new Alterar1();
            editar.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
