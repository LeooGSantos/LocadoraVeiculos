using System;

namespace LocadoraVeiculos.Models
{
    public class Aluguel
    {
        // Propriedades da classe Aluguel
        public int Id { get; set; }
        public Veiculo Veiculo { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal ValorAluguel { get; set; }

        // Construtor da classe Aluguel
        public Aluguel(int id, Veiculo veiculo, Cliente cliente, DateTime dataInicio, DateTime dataFim, decimal valorAluguel)
        {
            Id = id;
            Veiculo = veiculo;
            Cliente = cliente;
            DataInicio = dataInicio;
            DataFim = dataFim;
            ValorAluguel = valorAluguel;
        }

        // Método para calcular a duração do aluguel em dias (protegido)
        protected int CalcularDuracaoAluguelEmDiasProtected()
        {
            TimeSpan duracao = DataFim - DataInicio;
            return duracao.Days;
        }

        // Método para calcular o valor total do aluguel (interno)
        internal decimal CalcularValorTotalAluguelInternal()
        {
            int diasAluguel = CalcularDuracaoAluguelEmDiasProtected();
            return diasAluguel * ValorAluguel;
        }

        // Método público para calcular o valor total do aluguel
        public decimal CalcularValorTotalAluguel()
        {
            return CalcularValorTotalAluguelInternal();
        }

        // Método para calcular a duração do aluguel em dias (público)
        public int CalcularDuracaoAluguelEmDias()
        {
            return CalcularDuracaoAluguelEmDiasProtected();
        }

        // Método sobrescrito para retornar a representação textual do objeto Aluguel
        public override string ToString()
        {
            return $"ID: {Id}, Veículo: {Veiculo}, Cliente: {Cliente}, Data de Início: {DataInicio}, Data de Fim: {DataFim}, Valor do Aluguel: {ValorAluguel:C}";
        }
    }
}
