using System;

namespace OOP
{
    public class Pessoa
    {
        // ESTADO - representado pelas propriedades da classe, a pessoa vai possuir essas informações Nome: Pet, Dtnas: 13/04
        
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }


        // COMPORTAMENTO  = metodos - gera uma nova informação ou altera o estado da entidade / processa uma informação através da propria classe
        //ex: transformando a data de nascimento em uma idade pegando um formato data e retornando um tipo int
        //o méotodo tbm pode alterar o estado da classe
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}