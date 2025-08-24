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
            // Implementei o Readline para receber a entrada e adicionar elemento na lista através do veiculos.Add utilizando a variável placa
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa= Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
          

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // Utilizei o Readline para receber a entrada que irá para remoção.
            string placa = Console.ReadLine();
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // Utilizei a variável horas que irá receber a entrada de Readline. Porém, foi necessário realizar a conversão de int para String no recebimento. 
                // Então foi utilizado int.Parse. para a conversão
                int horas = int.Parse(Console.ReadLine());
                

                decimal valorTotal = precoInicial+precoPorHora*horas;
                
                

                // TODO: Remover a placa digitada da lista de veículos
                // Remoção.
                veiculos.Remove(placa);

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
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // Utilizei o for each criando a variável v que recebe o conteúdo de veiculos, listando corretamente.

                foreach (string v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
