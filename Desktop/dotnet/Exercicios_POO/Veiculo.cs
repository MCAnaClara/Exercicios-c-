namespace Exercicios_POO
{
    public class Veiculo
    {
        public decimal Velocidade{ get; private set; }
      
        public Veiculo(decimal velocidade)
        {
            if (velocidade > 200 || velocidade < 0)
            {
                Console.WriteLine("Velocidade inaceitável");
            }
            else
            {
                Console.WriteLine("Velocidade alterada");
                Velocidade = velocidade;
            }
        }
    }
}