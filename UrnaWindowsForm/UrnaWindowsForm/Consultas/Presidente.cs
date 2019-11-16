using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaWindowsForm.Consultas
{
    public class Presidente
    {
        private String ConsultaInserirPresidente = "INSERT INTO Presidente(cargoPolitico,numero,nome) VALUES (@cargoPolitico,@numero,@nome)";
        public string ConsultaPresidente()
        {
            return ConsultaInserirPresidente;
        }
    }
}
