using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Pilares_OOP
{
    /// <summary>
    /// Classe abstrata que não pode ser instânciada
    /// </summary>
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        /// <summary>
        /// Toda classe que herdar obrigatoriamente deverá passar nome e voltagem
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="voltagem"></param>
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }


        /// <summary>
        /// Método abstrato para a classe filha sobreescrever e implementar de acordo com a sua especialização
        /// </summary>
        public abstract void Ligar();
        /// <summary>
        /// Método abstrato para a classe filha sobreescrever e implementar de acordo com a sua especialização
        /// </summary>
        public abstract void Desligar();

        /// <summary>
        /// Método com um comportamento já predeterminado, porém pode ser sobreescrito
        /// </summary>
        public virtual void Testar()
        {
            // Ação para testar o equipamento eletrodoméstico
        }
    }
}
