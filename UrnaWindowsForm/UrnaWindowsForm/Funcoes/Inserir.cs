using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using UrnaWindowsForm.Cargos;

namespace UrnaWindowsForm.Funcoes
{
    public class Inserir
    {


        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        UrnaWindowsForm.Conexao.ConexaoMySql c = new UrnaWindowsForm.Conexao.ConexaoMySql();
        Retorno r = new Retorno();

        public void Cadastrar(int cargoPolitico, int numero, string nome, string estado,string Consulta)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            var comando = new MySqlCommand(Consulta, sqlcon);

            comando.Parameters.Add("@cargoPolitico", MySqlDbType.VarChar).Value = r.recebe(cargoPolitico);
            comando.Parameters.Add("@numero", MySqlDbType.Int32).Value = numero;
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@estado", MySqlDbType.VarChar).Value = estado;

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
