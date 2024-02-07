using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_estacionamento.models
{
    public class Veiculos
    {
        List<string> listaDeVeiculos = [];

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Qual a placa do veiculo");
            string placa = Console.ReadLine();
            listaDeVeiculos.Add(placa);
            
        }
        public void ListarVeiculos()
        {
            Console.WriteLine("Lista de veiculos");
                foreach(string i in listaDeVeiculos)
                {
                    Console.WriteLine(i);
                }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Qual a placa do veiculo a ser removido");
            string veiculoRemover = Console.ReadLine();

            if(!listaDeVeiculos.Contains(veiculoRemover)) {
                Console.WriteLine("\nVeiculo não encontrado, tente novamente...");
            }
            
            else {
                Console.WriteLine("Quantas horas o carro ficou estacionado?");
                decimal horas = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"Veiculo {veiculoRemover} removido e o preço total foi de: R${horas * 15}");
                listaDeVeiculos.Remove(veiculoRemover);
            }
        }
    }
}