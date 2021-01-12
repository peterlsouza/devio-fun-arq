using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjetoB")] // interna mas tbm visivel para o projeto que contenha o nome : ..... 
namespace ProjetoA
{
    #region Classes

    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    public sealed class Selada { } //sealed - nao pode ser herdada, somente instanciada

    class Privada { } //privada! não precisa declarar private class.. quando nao declara nada por padrão sera privada

    internal class Interna { }

    abstract class Abstrata { }

    #endregion
    
    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada(); //consegue instanciar por estar no mesmo assembly
            var interna = new Interna(); //consegue instanciar por estar no mesmo assembly
            //var abstrata = new Abstrata(); //nao pode ser instanciada por ser abstrata
        }
    }

    //class TesteSelada : Selada { } //teste herança da classe selada.. tbm nao funciona..

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno(); //consegue chamar pois é protected internal
            //publica.TesteProtegido(); //metodo protected, não consegue chamar pois nao herda a classe que o contem..
            //publica.TestePrivadoProtegido(); //metodo private protected, não consegue chamar pois nao herda a classe que o contem..
            //publica.TestePrivado(); //só funciona se herdar da classe que o contem
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            //Teste Herdando de Publica:  consegue chamar todos metodos publicos, internal, protectected, protected internal, protected
            TestePublico();
            TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            TestePrivadoProtegido();
            //TestePrivado(); //private não vai pois é privado somente a classe interna, dona do metodo..
        }
    }

    #endregion
}

/*******************************************************/
// public:

// Access is not restricted.
/*******************************************************/
// protected:

// Access is limited to the containing class or types
// derived from the containing class.
/*******************************************************/
// internal:

// Access is limited to the current assembly.
/*******************************************************/
// protected internal:

// Access is limited to the current assembly or types
// derived from the containing class.
/*******************************************************/
// private:

// Access is limited to the containing type.
/*******************************************************/
// private protected:

// Access is limited to the containing class or types
// derived from the containing class within the current
// assembly.Available since C# 7.2.
/*******************************************************/
