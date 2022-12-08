namespace EstacionamentoSystem.Models
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
        public void Addveiculo()
        {
            Console.WriteLine("Digite a placa de seu veículo: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do seu veículo para remover: ");
            string placa = Console.ReadLine();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite o tempo que o veículo permaneceu estacionado");
                
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço do serviço ficou no total de: R${valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe mas este veículo não está cadastrado em nosso sistema. Confira se os dados estão corretos");
            }

        }

        public void ListarVeiculos()
        {
            if(veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach(string veiculos_list in veiculos)
                {
                    Console.WriteLine($"veículo: {veiculos_list}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados no estacionamento.");
            }
        }
    }
}