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

namespace UrnaWindowsForm.Interface.CargoEleitoralInterface
{
    public partial class Governador : Form
    {
        PesquisarCandidato pesquisar = new PesquisarCandidato();
        Votar v = new Votar();
        public Governador()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pesquisar.Buscando(int.Parse(txtNumBuscaGovernador.Text));

            var recebeNumero = Convert.ToString(pesquisar.NumeroRecebido);
            txtNumGovernador.Text = recebeNumero;

            txtNomeGovernador.Text = pesquisar.Nome;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            v.Buscando(int.Parse(txtNumGovernador.Text));
            Close();
        }
    }
}
