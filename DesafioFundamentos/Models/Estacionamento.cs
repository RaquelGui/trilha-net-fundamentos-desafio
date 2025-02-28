using System.Dynamic;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaVeiculo = Console.ReadLine();
                
            // Adiciona a placa do veículo à lista de veículos
            veiculos.Add(placaVeiculo);   

            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaVeiculo = Console.ReadLine();
                       

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                int horas = int.Parse(Console.ReadLine());

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal 
                decimal valorTotal = precoInicial + precoPorHora * horas;
                
                // TODO: Remover a placa digitada da lista de veículos
                 // Remover a placa digitada da lista de veículos
                veiculos.Remove(placaVeiculo);

                Console.WriteLine($"O veículo {placaVeiculo} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var placaVeiculo in veiculos)
                    {
                        Console.WriteLine(placaVeiculo);
                    }
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
