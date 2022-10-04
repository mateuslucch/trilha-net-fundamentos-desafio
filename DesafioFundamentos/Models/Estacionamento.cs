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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string novoVeiculo = Console.ReadLine();
            veiculos.Add(novoVeiculo);
            Console.WriteLine($"Veículo {novoVeiculo} cadastrado!");
        }

        public void RemoverVeiculo()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Digite a placa do veículo para remover ou 1 para mostrar a lista de veículos cadastrados:");
                Console.WriteLine("");
                string placa = "";
                placa = Console.ReadLine();

                if (placa == "1")
                {
                    ListarVeiculos();
                }
                // Verifica se o veículo existe
                else if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    int horas = 0;
                    horas = int.Parse(Console.ReadLine());
                    decimal valorTotal = 0;
                    valorTotal = precoInicial + precoPorHora * horas;

                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    break;
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
