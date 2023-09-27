using rhilary.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhilary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a categoria do veículo:");
            Console.WriteLine("1 - Passeio");
            Console.WriteLine("2 - Utilitário");
            Console.WriteLine("3 - Ônibus");
            Console.WriteLine("4 - Caminhão");

            int categoria = int.Parse(Console.ReadLine());

            Console.Write("Informe a placa do veículo: ");
            string placa = Console.ReadLine();

            Console.Write("Informe a quantidade de eixos: ");
            int quantidadeEixos = int.Parse(Console.ReadLine());

            int tipoDesconto;
            do
            {
                Console.WriteLine("Selecione o tipo (1, 2 ou 3) para o desconto:");
            } while (!int.TryParse(Console.ReadLine(), out tipoDesconto) || tipoDesconto < 1 || tipoDesconto > 3);

            Veiculo veiculo;

            switch (categoria)
            {
                case 1:
                    veiculo = new CarroPasseio(placa, quantidadeEixos, tipoDesconto);
                    break;
                case 2:
                    veiculo = new CarroUtilitario(placa, quantidadeEixos, tipoDesconto);
                    break;
                case 3:
                    veiculo = new Onibus(placa, quantidadeEixos, tipoDesconto);
                    break;
                case 4:
                    veiculo = new Caminhao(placa, quantidadeEixos, tipoDesconto);
                    break;
                default:
                    Console.WriteLine("Categoria inválida");
                    return;
            }

            double valorPedagio = veiculo.CalcularPedagio();
            double desconto = veiculo.CalcularDesconto(valorPedagio);
            double valorFinal = valorPedagio - desconto;

            Console.WriteLine($"Placa: {veiculo.Placa}");
            Console.WriteLine($"Valor do Pedágio: R$ {valorPedagio:F2}");
            Console.WriteLine($"Desconto: R$ {desconto:F2}");
            Console.WriteLine($"Valor Final: R$ {valorFinal:F2}");
        }
    }
}
