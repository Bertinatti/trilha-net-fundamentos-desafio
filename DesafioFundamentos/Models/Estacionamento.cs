namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        /// <summary>
        /// Método construtor para criar o estacionamento, com dois parâmetros decimais.
        /// </summary>
        /// <param name="precoInicial">O primeiro valor decimal para ser atribuido ao preço inicial para entrar no estacionamento.</param>
        /// <param name="precoPorHora">O segunvo valor decimal para ser atribuido ao preço por hora do estacionamento.</param>
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo está estacionado. Não podem existir placas repetidas.
            if (!veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                veiculos.Add(placa);
            }
            else
            {
                Console.WriteLine($"O veículo de placa {placa} já está estacionado!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo está estacionado.
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                bool verificarHoras = true;
                int horas;
                decimal valorTotal = 0;

                // Looping para assegurar que seja digitado um valor inteiro para a quantidade de horas.
                while (verificarHoras)
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    if(int.TryParse(Console.ReadLine(), out horas))
                    {
                        valorTotal = this.precoInicial + this.precoPorHora * horas;
                        verificarHoras = false;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um valor inteiro para a quantidade de horas.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:f}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento.
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
