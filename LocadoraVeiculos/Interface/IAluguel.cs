using LocadoraVeiculos.Models;
using System;

namespace LocadoraVeiculos.Interface
{
    public interface IAluguel
    {
        // Método para realizar um aluguel de veículo
        void RealizarAluguel(Veiculo veiculo, Cliente cliente, DateTime dataInicio, DateTime dataFim, decimal valorAluguel);

        // Método para encerrar um aluguel de veículo
        void EncerrarAluguel(Aluguel aluguel, DateTime dataDevolucao);

        // Método para obter informações sobre aluguéis anteriores
        string ObterInformacoesAlugueisAnteriores(Cliente cliente);
    }
}
