using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaWindowsForm.Consultas
{
    public class Prefeito
    {
        private String ConsultaInserirPrefeito = "INSERT INTO prefeito(cargoPolitico,numero,nome,estado) VALUES (@cargoPolitico,@numero,@nome,@estado)";
        public string ConsultaPrefeito()
        {
            return ConsultaInserirPrefeito;
        }
    }
}
