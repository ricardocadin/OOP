using OOP.Classe_vs_Objeto;
using OOP.Interface_vs_Implementacao;
using OOP.Pilares_OOP;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Classe vs Objeto");
            Console.WriteLine("2 - Estado e comportamento");
            Console.WriteLine("3 - Herança");
            Console.WriteLine("4 - Usando encapsulamento");
            Console.WriteLine("5 - Interface Implementacao");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Exemplo de um objeto através de uma classe Carro");
                    Console.WriteLine();

                    var carro = new Carro().CriarNovoCarro();

                    Console.WriteLine("Classe: {0}", typeof(Carro).Name);
                    Console.WriteLine("Objeto:");
                    Console.WriteLine(string.Format("Farol de milha: {0} - Alarme: {1} - Bancos: {2} - {3} Portas - {4} KM/H", carro.FarolMilha, carro.Alarme, carro.NumeroAssento, carro.NumeroPortas, carro.VelocidadeMaxima));
                    Console.WriteLine(); 

                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Da-se um estado a classe criado sua instância");
                    Console.WriteLine();

                    var ricardo = new Pessoa("Ricardo", Convert.ToDateTime("1994/05/03"));

                    var idade = ricardo.CalcularIdade();

                    Console.WriteLine("Ricardo possui {0} anos. Idade obtida através de um comportamento", idade);
                    Console.WriteLine();

                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Cria uma pessoa física que é herança de pessoa");
                    Console.WriteLine();

                    var pessoaFisica = new PessoaFisica("Ricardo", Convert.ToDateTime("1994/05/03"));
                    pessoaFisica.Cpf = "111.111.111-11";

                    Console.WriteLine("Reaproveita do mesmo método para calcula idade e das propriedades da pessoa");

                    var idadePessoaFisica = pessoaFisica.CalcularIdade();

                    Console.WriteLine("Classe: {0}", pessoaFisica.GetType().Name);
                    Console.WriteLine("Nome: {0} - Data Nascimento: {1} - Idade: {2}", pessoaFisica.Nome, pessoaFisica.DataNascimento, idadePessoaFisica);
                    Console.WriteLine();

                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Usando de um encapsulamento para preparar uma vitamina");
                    Console.WriteLine();

                    var encapsulamento = new Encapsulamento().PrepararVitamina();

                    Console.WriteLine(encapsulamento);
                    Console.WriteLine();

                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Use o debug para visualizar as diferenças nas formas via código");
                    Console.WriteLine();

                    new TesteInterfaceImplementacao();

                    break;
                default:
                    break;
            }

            Console.Write("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
