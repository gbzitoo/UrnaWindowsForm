using System;
using System.Windows.Forms;
using UrnaWindowsForm.Cidade;
using UrnaWindowsForm.Consultas;
using UrnaWindowsForm.Funcoes;

namespace UrnaWindowsForm.Interface.CadastroCargoInterface
{
    public partial class CPrefeito : Form
    {
        public CPrefeito()
        {
            InitializeComponent();
        }

        private void BntCadastrarPresidente_Click(object sender, EventArgs e)
        {
            var inserir = new Inserir();
            var prefeito = new Prefeito();
            inserir.Cadastrar(6, Convert.ToInt32(txtNumPrefeito.Text), txtNomePrefeito.Text, ComboBox.SelectedItem.ToString(), prefeito.ConsultaPrefeito());
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conCidade = new ConsultaCidade();
            if (ComboBox.SelectedItem.ToString() == "RJ")
            {
                var items = conCidade.ResultadoSigla(ComboBox.SelectedItem.ToString());
                foreach (var item in items)
                {
                    comboBox1.Items.Add(item.ToString());
                }
                
            }
        }
    }
}
