using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaWindowsForm.Consultas;
using UrnaWindowsForm.Funcoes;

namespace UrnaWindowsForm.Interface.CadastroCargoInterface
{
    public partial class CGovernador : Form
    {
        public CGovernador()
        {
            InitializeComponent();
        }

        private void BntCadastrarPresidente_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            Governador gov = new Governador();
            inserir.Cadastrar(2, Convert.ToInt32(txtNumGovernador.Text), txtNomeGovernador.Text, ComboBox.SelectedItem.ToString(),gov.ConsultaGovernador());
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
