using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaWindowsForm.Cargos
{
    public class Retorno
    {
        private string recebeValor = "";
        public string recebe(int id)
        {
            if (id == 1)
            {
                recebeValor = Convert.ToString(CargoEnum.Presidente);
            }
            if (id == 2)
            {
                recebeValor = Convert.ToString(CargoEnum.Governador);
            }
            if (id == 3)
            {
                recebeValor = Convert.ToString(CargoEnum.Senador);
            }
            if (id == 4)
            {
                recebeValor = Convert.ToString(CargoEnum.DeputadoFederal);
            }
            if (id == 5)
            {
                recebeValor = Convert.ToString(CargoEnum.DeputadoEstadual);
            }
            if (id == 6)
            {
                recebeValor = Convert.ToString(CargoEnum.Prefeito);
            }
            if (id == 7)
            {
                recebeValor = Convert.ToString(CargoEnum.Vereador);
            }

            return recebeValor;
        }
    }
}
