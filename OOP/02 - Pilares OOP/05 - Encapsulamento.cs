
namespace OOP
{
    public class AutomacaoCafe
    {
        //Encapsulamento - Encapsular comportamentos atraves da exposição de metodos publicos e tbm metodos privados
        public void ServirCafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}