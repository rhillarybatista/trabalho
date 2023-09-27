using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhilary.classes
{
    class Veiculo
    {
        public string Placa { get; set; }
        public int QuantidadeEixos { get; set; }
        public int TipoDesconto { get; set; }

        public Veiculo(string placa, int quantidadeEixos, int tipoDesconto)
        {
            Placa = placa;
            QuantidadeEixos = quantidadeEixos;
            TipoDesconto = tipoDesconto;
        }
        public virtual double CalcularPedagio()
        {
            return 0;
        }
        public double CalcularDesconto(double valorPedagio)
        {
            double desconto = 0;

            switch (TipoDesconto)
            {
                case 2:
                    desconto = 0.05 * valorPedagio;
                    break;
                case 3:
                    desconto = valorPedagio;
                    break;
            }
            return desconto;
        }
    }
}
