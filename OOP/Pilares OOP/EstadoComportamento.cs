using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Pilares_OOP
{
    /// <summary>
    /// Classe Pessoa
    /// </summary>
    public class Pessoa
    {
        /// <summary>
        /// Estado - Nome
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Estado - Data Nascimento
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento.Date;
        }

        /// <summary>
        /// Comportamento gerando informação através de um estado da classe
        /// </summary>
        /// <returns></returns>
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}
