using System;

namespace UrnaWindowsForm.Consultas
{
    public class Senador
    {
        private String ConsultaInserirSenador = "INSERT INTO Senador(cargoPolitico,numero,nome,estado) VALUES (@cargoPolitico,@numero,@nome,@estado)";
        public string ConsultaSenador()
        {
            return ConsultaInserirSenador;
        }
    }
}
