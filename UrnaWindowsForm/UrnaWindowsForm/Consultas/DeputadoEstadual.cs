using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaWindowsForm.Consultas
{
    public class DeputadoEstadual
    {
        private String ConsultaInserirDeputadoEstadual = "INSERT INTO deputadoEstadual(cargoPolitico,numero,nome,estado) VALUES (@cargoPolitico,@numero,@nome,@estado)";
        public string ConsultaDeputadoEstadual()
        {
            return ConsultaInserirDeputadoEstadual;
        }
    }
}
