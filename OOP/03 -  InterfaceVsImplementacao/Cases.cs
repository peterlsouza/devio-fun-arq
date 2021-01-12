//Sempre que possivel... Usar INTERFACE no lugar de uma simples implementação!!!
//Interface - Tipo contrato.. quem implenta a interface é obrigada a implementar os metodos especificados na interface
// Classe abstrata alem de implementar metodos tbm implementa comportamentos que podem ser derivados..
// Interface é um contrato simples, vai implementar os metodos especificados na interface.. 
namespace OOP
{
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        //public Repositorio(int a)
        //{

        //}

        public void Adicionar()
        {
            // Adiciona item
        }
    }

    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            // Adiciona item
        }
    }

    public class UsoImplementacao
    {
        public void Processo()
        {
            var repositorio = new Repositorio(); // Implementando.. criando uma instancia... se mudar lá na interface, quebra essa implementação..
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao
    {
        private readonly IRepositorio _repositorio;

        public UsoAbstracao(IRepositorio repositorio) // injetando dependencia..  abstraido atraves do contrato.
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

            var repoAbs = new UsoAbstracao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioFake());
            repoAbsFake.Processo();
        }
    }
}
