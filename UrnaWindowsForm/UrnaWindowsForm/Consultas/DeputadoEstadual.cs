using System;

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
