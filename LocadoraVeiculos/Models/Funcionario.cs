namespace LocadoraVeiculos.Models
{
    public class Funcionario
    {
        // Propriedades da classe Funcionario
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        // Construtor da classe Funcionario
        public Funcionario(int id, string nome, string cargo, decimal salario)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        // Método para retornar o objeto Funcionario
        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Cargo: {Cargo}, Salário: {Salario:C}";
        }
    }
}
