using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaWindowsForm.Funcoes;

namespace UrnaWindowsForm.Interface.CargoEleitoralInterface
{
    public partial class Presidente : Form
    {
        
        public Presidente()
        {
            InitializeComponent();

        }

        PesquisarCandidato pesquisar = new PesquisarCandidato();
        Votar v = new Votar();
        private void Presidente_Load(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pesquisar.Buscando(int.Parse(txtNumBuscaPresidente.Text));

            var recebeNumero = Convert.ToString(pesquisar.NumeroRecebido);
            txtNumPresidente.Text = recebeNumero;

            txtNomePresidente.Text = pesquisar.Nome;


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            v.Buscando(int.Parse(txtNumPresidente.Text));
            Close();
        }
    }
}
