using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Interface_vs_Implementacao
{
    /// <summary>
    /// Interface de contrato
    /// </summary>
    public interface IRepositorio
    {
        void Adicionar();
    }

    /// <summary>
    /// Implementa o contrato
    /// </summary>
    public class Repositorio : IRepositorio
    {
        // Pode modificar essa classe, seu construtuor que não irá afetar a classe consumidora da interface

        public void Adicionar()
        {
            // Adiciona um item
        }
    }

    /// <summary>
    /// O contrato é o mesmo, a forma que uma classe implementa o método não importa para o consumidor
    /// </summary>
    public class RepositorioTest : IRepositorio
    {
        public void Adicionar()
        {
            // realiza a etapa de test mock para adicionar um item
        }
    }

    /// <summary>
    /// Uso de implementação com alto acoplamento
    /// </summary>
    public class UsoImplementacao
    {
        public void Processo()
        {
            //utilização concreta da classe, se algo muda para sua criação a implementação quebra
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    /// <summary>
    /// Uso de abstração
    /// </summary>
    public class UsoAbstracao
    {
        private readonly IRepositorio _repositorio;

        /// <summary>
        /// Não tem dependência direto da classe que implementa e sim requisita alguem que implemente o contrato
        /// A injeção de dependência resolve a forma que o objeto será criado de maneira transparente
        /// </summary>
        /// <param name="repositorio"></param>
        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            //Claramente se tivesse o uso de um componente de IoC a instância não seria passado de maneira direta
            //foi feito dessa forma somente para exemplificar
            var repoAbs = new UsoAbstracao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioTest());
            repoAbsFake.Processo();
        }
    }
}
