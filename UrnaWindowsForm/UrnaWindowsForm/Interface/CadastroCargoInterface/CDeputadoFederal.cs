using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaWindowsForm.Funcoes;

namespace UrnaWindowsForm.Interface.CadastroCargoInterface
{
    public partial class CDeputadoFederal : Form
    {
        public CDeputadoFederal()
        {
            InitializeComponent();
        }

        private void BntCadastrarPresidente_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            inserir.Cadastrar(4, Convert.ToInt32(txtNumDeputadoFederal.Text), txtNomeDeputadoFederal.Text);
        }
    }
}
