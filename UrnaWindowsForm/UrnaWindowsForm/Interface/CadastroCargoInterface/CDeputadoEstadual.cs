using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaWindowsForm.Cidade;
using UrnaWindowsForm.Consultas;
using UrnaWindowsForm.Funcoes;

namespace UrnaWindowsForm.Interface.CadastroCargoInterface
{
    public partial class CDeputadoEstadual : Form
    {
        public CDeputadoEstadual()
        {
            InitializeComponent();
        }

        private void BntCadastrarPresidente_Click(object sender, EventArgs e)
        {
            var inserir = new Inserir();
            var deputadoEstadual = new DeputadoEstadual();
            inserir.Cadastrar(5, Convert.ToInt32(txtNumDeputadoEstadual.Text), txtNomeDeputadoEstadual.Text, ComboBox.SelectedItem.ToString(),deputadoEstadual.ConsultaDeputadoEstadual());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var conCidade = new ConsultaCidade();

            //MessageBox.Show(conCidade.ResultadoSigla(textBox1.Text).ToString());
        }
    }
}
