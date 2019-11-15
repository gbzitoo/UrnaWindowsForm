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
        public Form _objCadastrarCandidato = new Form();
        public Form _objGanhador = new Form();
        public Form _objListarCandidato = new Form();
        public Form _objVotar = new Form();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Urna Eletrônica";

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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
