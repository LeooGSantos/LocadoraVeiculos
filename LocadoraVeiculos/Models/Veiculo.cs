namespace LocadoraVeiculos.Models
{
    public class Veiculo
    {
        // Propriedades da classe Veiculo
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Tipo { get; set; }
        public bool Disponibilidade { get; set; }
        

        // Construtor da classe Veiculo
        public Veiculo(int id, string modelo, int ano, string tipo, bool disponibilidade)
        {
            Id = id;
            Modelo = modelo;
            Ano = ano;
            Tipo = tipo;
            Disponibilidade = disponibilidade;
        }

        // Método para retornar o objeto Veiculo
        public override string ToString()
        {
            return $"ID: {Id}, Modelo: {Modelo}, Ano: {Ano}, Tipo: {Tipo}, Disponibilidade: {(Disponibilidade ? "Disponível" : "Indisponível")}";
        }
    }
}
