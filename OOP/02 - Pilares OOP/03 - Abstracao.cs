namespace OOP
{
    public abstract class Eletrodomestico //abstract class - proibi que alguem instancie.. ela só pode ser herdada!
    {   
        //ABSTRAÇÃO - oferecer um conjunto de estados e comportamentos que abstraem uma certa especialização
        //Criar conceitos genéricos que possam ser abstraidos por outras classes
        private readonly string _nome;
        private readonly int _voltagem;
        
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        //metodo abstrato - não é obrigado a implementar o comportamento dele.. 
        public abstract void Ligar();
        public abstract void Desligar();

        public virtual void Testar() ///virtual - não obriga a sobreescrita mas permite se desejar...
        {
            // teste do equipamento
        }
    }
}