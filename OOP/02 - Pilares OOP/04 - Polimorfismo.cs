namespace OOP
{
    // Poli-morfismo - Muitos comportamentos
    // especialização da classe Eletrodomestico para cafeteira...
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem) : base(nome, voltagem) 
        {
            
        }

        public CafeteiraEspressa() : base("Padrao", 220) 
        {

        }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

       //este metodo na classe base é virtual.. não obriga a sobreescrita, mas permite se desejar
        public override void Testar()
        {
            // teste de cafeteira
        }

        //como os metodos da classe base são abstratos, somos obrigados a sobreescrever os mesmos quando os herdamos..
        //override - sobreescrevendo o comportamento da classe base ligar... 
        public override void Ligar() 
        {
            // Verificar recipiente de agua
        }

        public override void Desligar()
        {
            // Resfriar aquecedor
        }
    }
}