using System;

namespace DemoDI.Cases
{
    public class OperacaoService
    {
        //Transient - *Modelo padrão e mais comum de se utilizar, se não souber qual usar.. vai de Transient
        //*dependencia será criada cada vez que for injetada na classe, cada vez que solicitado cria uma nova instância, será alocado mais memória..
        //Serviços temporários de tempo de vida (AddTransient) são criados cada vez que são solicitados pelo container de serviço. 
        //Esse tempo de vida funciona melhor para serviços leves e sem estado. Em aplicativos que processam solicitações, os serviços transitórios são descartados no final da solicitação.
        //
        //AddScoped - criados apenas uma vez, por request.. para aplicação Web, ideal o Scoped
        //criados apenas uma vez por requeOs serviços com tempo de vida (AddScoped) com escopo são criados uma vez por solicitação de cliente (conexão).
        //Em aplicativos que processam solicitações, os serviços com escopo são descartados no final da solicitação.
        //
        //AddSingleton - *cria uma unica instância para toda aplicação
        //Serviços de tempo de vida singleton(AddSingleton) são criados na primeira solicitação(ou quando Startup.ConfigureServices é executado e uma 
        //instância é especificada com o registro do serviço). Cada solicitação subsequente usa a mesma instância.
        //Se o aplicativo exigir um comportamento de singleton, recomendamos permitir que o contêiner do serviço gerencie o tempo de vida do serviço.
        //Não implemente o padrão de design singleton e forneça o código de usuário para gerenciar o tempo de vida do objeto na classe.

        public OperacaoService(
            IOperacaoTransient transient,
            IOperacaoScoped scoped,
            IOperacaoSingleton singleton,
            IOperacaoSingletonInstance singletonInstance)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
            SingletonInstance = singletonInstance;
        }

        public IOperacaoTransient Transient { get; }
        public IOperacaoScoped Scoped { get; }
        public IOperacaoSingleton Singleton { get; }
        public IOperacaoSingletonInstance SingletonInstance { get; }
    }

    public class Operacao : IOperacaoTransient,
        IOperacaoScoped,
        IOperacaoSingleton,
        IOperacaoSingletonInstance
    {
        public Operacao() : this(Guid.NewGuid())
        {
        }

        public Operacao(Guid id)
        {
            OperacaoId = id;
        }

        public Guid OperacaoId { get; private set; }
    }

    public interface IOperacao
    {
        Guid OperacaoId { get; }
    }

    public interface IOperacaoTransient : IOperacao
    {
    }

    public interface IOperacaoScoped : IOperacao
    {
    }

    public interface IOperacaoSingleton : IOperacao
    {
    }

    public interface IOperacaoSingletonInstance : IOperacao
    {
    }
}