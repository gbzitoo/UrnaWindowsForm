using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaWindowsForm.Consultas
{
    public class Vereador
    {
        private String ConsultaInserirVereador = "INSERT INTO vereador(cargoPolitico,numero,nome,estado) VALUES (@cargoPolitico,@numero,@nome,@estado)";
        public string ConsultaVereador()
        {
            return ConsultaInserirVereador;
        }
    }
}
