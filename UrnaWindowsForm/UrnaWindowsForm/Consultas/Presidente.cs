using System;

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
