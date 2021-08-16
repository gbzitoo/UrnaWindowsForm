using System;

namespace UrnaWindowsForm.Consultas
{
    public class DeputadoFederal
    {
        private String ConsultaInserirDeputadoFederal = "INSERT INTO deputadofederal(cargoPolitico,numero,nome,estado) VALUES (@cargoPolitico,@numero,@nome,@estado)";
        public string ConsultaDeputadoFederal()
        {
            return ConsultaInserirDeputadoFederal;
        }
    }
}
