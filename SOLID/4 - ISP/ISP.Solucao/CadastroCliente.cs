using SOLID.ISP.Solucao.Interfaces;

namespace SOLID.ISP.Solucao
{
    //ISP - Interface Segregation Principle
    //Clientes não devem ser forçados a depender de métodos que não usam
    //Muitas interfaces especificas são melhores do que uma interface unica


    public class CadastroCliente : ICadastroCliente
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o cliente
        }
    }
}