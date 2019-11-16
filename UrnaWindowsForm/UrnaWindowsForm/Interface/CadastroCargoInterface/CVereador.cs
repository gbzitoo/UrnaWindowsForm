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
    public partial class CVereador : Form
    {
        public CVereador()
        {
            InitializeComponent();
        }

        private void BntCadastrarPresidente_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            Vereador ver = new Vereador();
             inserir.Cadastrar(7, Convert.ToInt32(txtNumVereador.Text), txtNomeVereador.Text, ComboBox.SelectedItem.ToString(),ver.ConsultaVereador());
        }
    }
}
