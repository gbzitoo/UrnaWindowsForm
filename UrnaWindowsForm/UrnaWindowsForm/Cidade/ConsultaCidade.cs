using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaWindowsForm.Cidade
{
    public class ConsultaCidade
    {
        public String RecebeCidades { get; set; }
        public int ValorEstado = 0;

        public string ResultadoSigla(string sigla)
        {
           //Verificando qual estado é e adicionando a quantidade de cidades no array.
            if (sigla == "RJ")
            {
                //93 cidades no estado do rio.
                ValorEstado = 93;

            }else if (sigla == "SP")
            {
                ValorEstado = 5;
            }

            String[] cidades = new string[ValorEstado];

            // Cidades do Rio de Janeiro.
            if (sigla == "RJ")
            {
                cidades[0] = "Angra dos Reis";
                cidades[1] = "Aperibé";
                cidades[2] = "Araruama";
                cidades[3] = "Areal";
                cidades[4] = "Armação de Búzios";
                cidades[5] = "Arraial do Cabo";
                cidades[6] = "Barra do Piraí";
                cidades[7] = "Barra Mansa";
                cidades[8] = "Belford Roxo";
                cidades[9] = "Bom Jardim";
                cidades[10] = "Bom Jesus do Itabapoana";
                cidades[12] = "Cabo Frio";
                cidades[13] = "Cabo Frio";
                cidades[14] = "Cabo Frio";
                cidades[15] = "Cabo Frio";
                cidades[16] = "Cabo Frio";
                cidades[17] = "Cabo Frio";
                cidades[18] = "Cabo Frio";
                cidades[19] = "Cabo Frio";
                cidades[20] = "Cabo Frio";
                cidades[21] = "Cabo Frio";
                cidades[22] = "Cabo Frio";
                cidades[23] = "Cabo Frio";
                cidades[24] = "Cabo Frio";
                cidades[25] = "Cabo Frio";
                cidades[26] = "Cabo Frio";
                cidades[27] = "Cabo Frio";
                cidades[28] = "Cabo Frio";
                cidades[29] = "Cabo Frio";
                cidades[30] = "Cabo Frio";
                cidades[31] = "Cabo Frio";
                cidades[32] = "Cabo Frio";
                cidades[33] = "Cabo Frio";
                cidades[34] = "Cabo Frio";
                cidades[35] = "Cabo Frio";
                cidades[36] = "Cabo Frio";
                cidades[37] = "Cabo Frio";
                cidades[38] = "Cabo Frio";
                cidades[39] = "Cabo Frio";
                cidades[40] = "Cabo Frio";
                cidades[41] = "Cabo Frio";
                cidades[42] = "Cabo Frio";
                cidades[43] = "Cabo Frio";
                cidades[44] = "Cabo Frio";
                cidades[45] = "Cabo Frio";
                cidades[46] = "Cabo Frio";
                cidades[47] = "Cabo Frio";
                cidades[48] = "Cabo Frio";
                cidades[49] = "Cabo Frio";
                cidades[50] = "Cabo Frio";
                cidades[51] = "Cabo Frio";
                cidades[52] = "Cabo Frio";
                cidades[53] = "Cabo Frio";
                cidades[54] = "Cabo Frio";
                cidades[55] = "Cabo Frio";
                cidades[56] = "Cabo Frio";
                cidades[57] = "Cabo Frio";
                cidades[58] = "Cabo Frio";
                cidades[59] = "Cabo Frio";
                cidades[60] = "Cabo Frio";
                cidades[61] = "Cabo Frio";
                cidades[62] = "Cabo Frio";
                cidades[63] = "Cabo Frio";
                cidades[64] = "Cabo Frio";
                cidades[65] = "Cabo Frio";
                cidades[66] = "Cabo Frio";
                cidades[67] = "Cabo Frio";
                cidades[68] = "Cabo Frio";
                cidades[69] = "Cabo Frio";
                cidades[70] = "Cabo Frio";
                cidades[71] = "Cabo Frio";
                cidades[72] = "Cabo Frio";
                cidades[73] = "Cabo Frio";
                cidades[74] = "Cabo Frio";
                cidades[75] = "Cabo Frio";
                cidades[76] = "Cabo Frio";
                cidades[77] = "Cabo Frio";
                cidades[78] = "Cabo Frio";
                cidades[79] = "Cabo Frio";
                cidades[80] = "Cabo Frio";
                cidades[81] = "Cabo Frio";
                cidades[82] = "Cabo Frio";
                cidades[83] = "Cabo Frio";
                cidades[84] = "Cabo Frio";
                cidades[85] = "Cabo Frio";
                cidades[86] = "Cabo Frio";
                cidades[87] = "Cabo Frio";
                cidades[88] = "Cabo Frio";
                cidades[89] = "Cabo Frio";
                cidades[90] = "Cabo Frio";
                cidades[91] = "Cabo Frio";
                cidades[92] = "Cabo Frio";
            }
            foreach (var item in cidades)
            {
                RecebeCidades += item;
            }


            // Cidades de são paulo.
            if (sigla == "SP")
            {
                cidades[0] = "Angra dos Reis\n";
                cidades[1] = "Aperibé\n";
                cidades[2] = "Araruama\n";
                cidades[3] = "Areal\n";
                cidades[4] = "Armação de Búzios\n";
            }
            foreach (var item in cidades)
            {
                RecebeCidades += item;
            }


            return RecebeCidades;

        }
    }
}
