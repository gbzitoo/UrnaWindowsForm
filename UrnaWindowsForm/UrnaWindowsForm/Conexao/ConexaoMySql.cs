using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaWindowsForm.Conexao
{
    public class ConexaoMySql
    {
        //String de conexão com o banco de dados.
        private String Server = "Server=127.0.0.1;port=3306;User Id=root;Database=candidatos;password=gabriel851";
        private static string strcon = "";

        public string Conn()
        {
            // esse for eu botei para ele ir percorrendo toda a string Server e ir guardando em uma variavel.
            var recebeValor = "";
            for (int i = 0; i <= Server.Length - 1; i++)
            {
                var h = Server[i];
                recebeValor += h;
            }
            //quando terminar o valor vai para o strcon e é retornado quando chamado a função Conn().
            strcon = recebeValor;

            return strcon;
        }
    }
}
