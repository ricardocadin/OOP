using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classe_vs_Objeto
{
    /// <summary>
    /// Classe que referencia um objeto da vida real com suas informações
    /// </summary>
    public class Carro
    {
        public int NumeroPortas { get; set; }
        public string FarolMilha { get; set; }
        public string Alarme { get; set; }
        public decimal VelocidadeMaxima { get; set; }
        public int NumeroAssento { get; set; }

        public Carro() { }

        /// <summary>
        /// Retorna um objeto que é uma instância da classe Carro
        /// </summary>
        /// <returns></returns>
        public Carro CriarNovoCarro()
        {
            return new Carro()
            {
                Alarme = "Sim",
                FarolMilha = "Sim",
                NumeroAssento = 5,
                NumeroPortas = 4,
                VelocidadeMaxima = 180
            };
        }
    }
}
