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
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("  E N T R A D A  D E  V E Í C U L O S     ");
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Desculpe! Este veículo já está cadastrado!");
                Console.WriteLine("------------------------------------------");
            }
            else
            {
                veiculos.Add(placa.Trim());
                Console.WriteLine("Veículo cadastrado com sucesso!\n");
            }
        }

        public void RemoverVeiculo()
        {
            int horas;
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("      S A Í D A  D E  V E Í C U L O S     ");
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            var placa = Console.ReadLine();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                //lê e converte para inteiro o número de horas que o veículo permaneceu estacionado
                horas = int.Parse(Console.ReadLine());
                decimal valorTotal = 0;
                //calcula o valor a ser pago
                valorTotal = (precoInicial + precoPorHora) * horas;
                //exclui o veículo da lista
                veiculos.Remove(placa.Trim());
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" V E Í C U L O S  E S T A C I O N A D O S ");
            Console.WriteLine("------------------------------------------\n");
                int contadorForeach = 0;
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                    contadorForeach++;
                }
                Console.WriteLine("--------");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
