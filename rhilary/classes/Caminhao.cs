using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhilary.classes
{
    class Caminhao : Veiculo
    {
        public Caminhao(string placa, int quantidadeEixos, int tipoDesconto)
        : base(placa, quantidadeEixos, tipoDesconto)
        {
        }

        public override double CalcularPedagio()
        {
            double valorBase = 7.00 * QuantidadeEixos;
            double taxaManutencao = 0.10 * valorBase;
            return valorBase + taxaManutencao;
        }
    }
}
