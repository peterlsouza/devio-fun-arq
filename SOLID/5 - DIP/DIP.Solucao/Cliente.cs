using System;
using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    //DIP - Dependency Inversion Principle
    //Dependa de uma abstração e não de uma implementação

    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}