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

    public class Votar
    {
        public static int Votos = 0;

        public string ConsultaProcurar = "SELECT votos FROM candidato WHERE numero=@numero";
        MySql.Data.MySqlClient.MySqlConnection sqlcon = null;
        //Chamando a classe conexao
        ConexaoMySql c = new ConexaoMySql();
        Votando pc = new Votando();
        public void Buscando(int Numero)
        {

            sqlcon = new MySql.Data.MySqlClient.MySqlConnection(c.Conn());
            MySqlCommand comando = new MySqlCommand(ConsultaProcurar, sqlcon);
            comando.Parameters.Add("@numero", MySqlDbType.Int32).Value = Numero;


            try
            {
                sqlcon.Open();
                MySqlDataReader dr = comando.ExecuteReader();

                //Verifica se tem o id passado na tabela.
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Numero não cadastrado!");
                }


                dr.Read();

                Votos = Convert.ToInt32(dr["votos"]);
                Votos = Votos + 1;


                pc.Votar(Numero,Votos);

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
