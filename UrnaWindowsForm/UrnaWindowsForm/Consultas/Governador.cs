using System;

namespace UrnaWindowsForm.Consultas
{
    public class Governador
    {
        private String ConsultaInserirGovernador = "INSERT INTO governador(cargoPolitico,numero,nome,estado) VALUES (@cargoPolitico,@numero,@nome,@estado)";
        public string ConsultaGovernador()
        {
            return ConsultaInserirGovernador;
        }
    }
}

