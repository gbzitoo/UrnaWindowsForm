using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace UrnaWindowsForm.Funcoes
{
    public class Votando
    {
        public string ConsultaVotando = "UPDATE candidato SET votos=@votos WHERE numero=@numero";
        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        UrnaWindowsForm.Conexao.ConexaoMySql c = new UrnaWindowsForm.Conexao.ConexaoMySql();
        public void Votar(int numero, int votos)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            var comando2 = new MySqlCommand(ConsultaVotando, sqlcon);
            comando2.Parameters.Add("@numero", MySqlDbType.Int32).Value = numero;
            comando2.Parameters.Add("@votos", MySqlDbType.Int32).Value = votos;


            try
            {
                sqlcon.Open();
                var dr2 = comando2.ExecuteReader();

                dr2.Read();
                MessageBox.Show("Voto cadastrado com sucesso.");
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
