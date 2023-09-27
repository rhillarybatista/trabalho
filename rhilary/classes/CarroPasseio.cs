using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhilary.classes
{
    class CarroPasseio : Veiculo
    {
        public CarroPasseio(string placa, int quantidadeEixos, int tipoDesconto)
        : base(placa, quantidadeEixos, tipoDesconto)
        {
        }

        public override double CalcularPedagio()
        {
            return 3.00 * QuantidadeEixos;
        }
    }
}
