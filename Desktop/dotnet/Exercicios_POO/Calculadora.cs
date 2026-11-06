namespace Exercicios_POO
{
    public class Calculadora
    {
        public int Somar(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        public int Subtrair(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        public int Multiplicar(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }
        

        public static int Dividir(int primeiroNumero, int segundoNumero)
        {
            // return primeiroNumero % segundoNumero;
            return primeiroNumero / segundoNumero;
        }
    }
}