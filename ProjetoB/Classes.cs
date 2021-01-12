using ProjetoA;

namespace ProjetoB
{
    class TesteClasses
    {
        public TesteClasses()
        {
            //tem dependencia do Projeto A onde estão as classes.. 
            //nao é possivel chamar os metodos privados, internos nem instancias abstratos
            //*********Porém.... 
            // se especificar lá no projeto A: [assembly: InternalsVisibleTo("ProjetoB")] vai conseguir acessar aqui no projeto B
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            //criando a instancia.. apenas metodo publico pode acessar... 
            //se especificar no proj A consegue algumas melhorias tbm.. [assembly: InternalsVisibleTo("ProjetoB")] 
            var publica = new Publica(); 

            publica.TestePublico();
            //publica.TesteInternal();
            //publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        //herdando a classe publica que é de outro assembly.. 
        public TesteModificador2()
        {
            TestePublico();
            TesteProtegido();
            TesteProtegidoInterno();
            //TesteInternal();
            //TestePrivadoProtegido();
            //TestePrivado();
        }
    }
}


