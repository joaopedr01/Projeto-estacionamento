using desafio_estacionamento.models;

Veiculos veiculos = new();

while(true) {

     Console.WriteLine("\n-------------------------\nA - Adicionar\nL - Listar\nR - Remover\nS - Sair\n-------------------------");
          
     Console.WriteLine("Escolha uma opcao de menu: ");
     string opcao = Console.ReadLine();


     if (opcao.ToLower() == "a") veiculos.AdicionarVeiculo();

     else if (opcao.ToLower() == "l") veiculos.ListarVeiculos(); 

     else if (opcao.ToLower() == "r") veiculos.RemoverVeiculo();       
     
     else if (opcao.ToLower() == "s") break;

     else throw new Exception("\nInsira uma das opções do menu, encerrando programa...\n");

}




// for (int count = 0; count < limite; count++)
// {

// }