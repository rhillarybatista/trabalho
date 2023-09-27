using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhilary.classes
{
    class CarroUtilitario : Veiculo
    {
        public CarroUtilitario(string placa, int quantidadeEixos, int tipoDesconto)
        : base(placa, quantidadeEixos, tipoDesconto)
        {
        }

        public override double CalcularPedagio()
        {
            double valorBase = 3.50 * QuantidadeEixos;
            double taxaManutencao = 0.02 * valorBase;
            return valorBase + taxaManutencao;
        }
    }
}
