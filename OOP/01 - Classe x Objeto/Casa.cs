namespace OOP
{
    // Definição de Classe
    //estrutura de código que tem a função de mapear/representar um objeto do mundo real

    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    //OBJETO = quando temos a nossa classe instanciada e alocada na memória 
    //essa instancia vai ser alocada na memoria

    public class Objeto
    {
        public Objeto()
        {
            // Definição de Objeto
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }
}