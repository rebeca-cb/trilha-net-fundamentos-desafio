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
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para estacionar:");
           
           
            string placa = Console.ReadLine().ToUpper(); 
            veiculos.Add(placa);

            Console.Write($"Veículo de placa {placa} adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            string placa = Console.ReadLine().ToUpper(); 
            

            
            if (veiculos.Contains(placa))
            {
                Console.Clear();
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                
                int horas = int.Parse(Console.ReadLine()); 
                
                decimal valorTotal = precoInicial + precoPorHora * horas;                 

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

            }
            else
            {
                Console.WriteLine($"Desculpe, veículo de placa {placa} não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach (var placa in veiculos)
                    Console.WriteLine(placa);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
