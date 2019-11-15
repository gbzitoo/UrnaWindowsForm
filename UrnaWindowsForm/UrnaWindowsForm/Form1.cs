using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VotarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void LimparUrnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementar o sistema de pergunta.
            //Perguntar se o usuário quer realmente limpar a urna.

            //Exemplo: 
            // Você Realmente deseja limpar essa urna? (s/n)
            // se o usuario botar s, o programa irá exluir tudo, caso o usuario bote n o programa ira voltar para pagina inicial.
            MessageBox.Show("Você limpou sua urma, todos os candidatos e votos cadastrados foram excluidos.");
        }
    }
}
