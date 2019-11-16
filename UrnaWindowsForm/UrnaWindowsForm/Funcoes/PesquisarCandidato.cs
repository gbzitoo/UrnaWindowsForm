using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaWindowsForm.Conexao;

namespace UrnaWindowsForm.Funcoes
{
    class PesquisarCandidato
    {
        public int NumeroRecebido;
        public String Nome = "";

        public string ConsultaProcurar = "SELECT numero, nome, votos FROM candidato WHERE numero=@numero";
        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        ConexaoMySql c = new ConexaoMySql();

        public void Buscando(int Numero)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(ConsultaProcurar, sqlcon);

            comando.Parameters.Add("@numero", MySqlDbType.Int32).Value = Numero;


            try
            {
                //Verifica se o campo está vazio.
                if (Convert.ToString(Numero) == string.Empty)
                {
                    MessageBox.Show("Você precisa por um Numero!");
                }


                sqlcon.Open();
                MySqlDataReader dr = comando.ExecuteReader();

                //Verifica se tem o id passado na tabela.
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Codigo não cadastrado!");
                }


                dr.Read();

                NumeroRecebido = Convert.ToInt32(dr["numero"]);
                Nome = Convert.ToString(dr["Nome"]);

            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
