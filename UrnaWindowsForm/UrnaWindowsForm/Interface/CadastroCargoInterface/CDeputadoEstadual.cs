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
    public partial class CDeputadoEstadual : Form
    {
        public CDeputadoEstadual()
        {
            InitializeComponent();
        }

        private void BntCadastrarPresidente_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            inserir.Cadastrar(5, Convert.ToInt32(txtNumDeputadoEstadual.Text), txtNomeDeputadoEstadual.Text);
        }
    }
}
