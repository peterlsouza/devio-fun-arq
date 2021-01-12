using System;

namespace SOLID.SRP.Solucao
{
    //SRP - Single Responsability Principle
    //Uma Classe deve ter um, e apenas um, motivo para ser modificada
    //*Podemos ter varios métodos na mesma classe, desde que todos façam parte de um unico propósito..

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