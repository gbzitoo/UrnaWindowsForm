using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaWindowsForm.Interface.CargoEleitoralInterface;

namespace UrnaWindowsForm
{
    public partial class Form1 : Form
    {
        public Form _objCadastrarCandidato = new Form();
        public Form _objGanhador = new Form();
        public Form _objListarCandidato = new Form();

        // Intarface Canditatos
        public Form _objPresidente = new Form();
        public Form _objGovernador = new Form();
        public Form _objSenador = new Form();
        public Form _objDeputadoFederal = new Form();
        public Form _objDeputadoEstadual = new Form();
        public Form _objPrefeito = new Form();
        public Form _objVereador = new Form();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Urna Eletrônica";

        }


        private void VotarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            _objPresidente?.Close();
            _objPresidente = new Presidente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            P_Principal.Controls.Add(_objPresidente);
            _objPresidente.Show();
            P_Principal.Visible = true;
        }

        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            _objGovernador?.Close();
            _objGovernador = new Governador
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            P_Principal.Controls.Add(_objGovernador);
            _objGovernador.Show();
            P_Principal.Visible = true;
        }

        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            _objSenador?.Close();
            _objSenador = new Senador
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            P_Principal.Controls.Add(_objSenador);
            _objSenador.Show();
            P_Principal.Visible = true;
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            _objDeputadoFederal?.Close();
            _objDeputadoFederal = new DeputadoFederal
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            P_Principal.Controls.Add(_objDeputadoFederal);
            _objDeputadoFederal.Show();
            P_Principal.Visible = true;
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            _objDeputadoEstadual?.Close();
            _objDeputadoEstadual = new DeputadoEstadual
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            P_Principal.Controls.Add(_objDeputadoEstadual);
            _objDeputadoEstadual.Show();
            P_Principal.Visible = true;
        }

        private void ToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            _objPrefeito?.Close();
            _objPrefeito = new Prefeito
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            P_Principal.Controls.Add(_objPrefeito);
            _objPrefeito.Show();
            P_Principal.Visible = true;
        }

        private void ToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            _objVereador?.Close();
            _objVereador = new Vereador
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            P_Principal.Controls.Add(_objVereador);
            _objVereador.Show();
            P_Principal.Visible = true;
        }
    }
}
