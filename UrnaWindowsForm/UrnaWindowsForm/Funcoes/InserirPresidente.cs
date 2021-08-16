using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using UrnaWindowsForm.Cargos;

namespace UrnaWindowsForm.Funcoes
{
    public class InserirPresidente
    {


        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        UrnaWindowsForm.Conexao.ConexaoMySql c = new UrnaWindowsForm.Conexao.ConexaoMySql();
        Retorno r = new Retorno();

        public void CadastrarPresidente(int cargoPolitico, int numero, string nome,string Consulta)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            var comando = new MySqlCommand(Consulta, sqlcon);

            comando.Parameters.Add("@cargoPolitico", MySqlDbType.VarChar).Value = r.recebe(cargoPolitico);
            comando.Parameters.Add("@numero", MySqlDbType.Int32).Value = numero;
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;

            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show(r.recebe(cargoPolitico) +" Cadastrado!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                sqlcon.Close();

            }

        }
    }
}
