namespace JogoDaVelhaPOO.Entities
{
    internal class Tabuleiro
    {
        public static char[,] tabuleiroDoJogo = new char[3, 3] { { '*', '*', '*' }, { '*', '*', '*' }, { '*', '*', '*' } };

        public static void LimparTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiroDoJogo[i, j] = '*';
                }
            }
        }

        public static void ImprimirTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabuleiroDoJogo[i, j] + "   "); 
                }
                Console.WriteLine("\n"); 
            }
        }
    }
}
