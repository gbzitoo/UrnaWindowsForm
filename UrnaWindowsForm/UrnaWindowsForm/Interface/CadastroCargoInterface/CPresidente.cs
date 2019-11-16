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
    public partial class CPresidente : Form
    {
        public CPresidente()
        {
            InitializeComponent();
        }

        private void BntCadastrarPresidente_Click(object sender, EventArgs e)
        {
            InserirPresidente inserirPresidente = new InserirPresidente();
            Presidente pre = new Presidente();
            inserirPresidente.CadastrarPresidente(1, Convert.ToInt32(txtNumPresidente.Text), txtNomePresidente.Text, pre.ConsultaPresidente());
        }
    }
}
