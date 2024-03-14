namespace LocadoraVeiculos.Models
{
    public class Cliente
    {
        // Propriedades da classe Cliente
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
       

        // Construtor da classe Cliente
        public Cliente(int id, string nome, int idade, string endereco)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

        // Método para retornar objeto Cliente
        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Idade: {Idade}, Endereço: {Endereco}";
        }
    }
}
