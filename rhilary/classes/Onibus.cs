using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhilary.classes
{
    class Onibus : Veiculo
    {
        public Onibus(string placa, int quantidadeEixos, int tipoDesconto)
        : base(placa, quantidadeEixos, tipoDesconto)
        {
        }

        public override double CalcularPedagio()
        {
            double valorBase = 5.00 * QuantidadeEixos;
            double taxaManutencao = 0.05 * valorBase;
            return valorBase + taxaManutencao;
        }
    }
}
