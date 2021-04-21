using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Pilares_OOP
{
    /// <summary>
    /// Classe pessoa física é uma pessoa? Sim, uma especialização
    /// </summary>
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        /// <summary>
        /// Cria uma instancia de pessoa física, porém passa as informações necessárias para a classe principal
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        public PessoaFisica(string nome, DateTime dataNascimento) : base(nome, dataNascimento)
        {
        }
    }

    public class Heranca
    {
        /// <summary>
        /// Exemplo utilização da herança
        /// </summary>
        public void Execucao()
        {
            //refaz utilização de propriedades da classe principal
            var pessoaFisica = new PessoaFisica("Ricardo", Convert.ToDateTime("1994/05/03"));
            pessoaFisica.Cpf = "111.111.111-11";

            //herda o comportamento da classe principal
            pessoaFisica.CalcularIdade();
        }
    }
}
