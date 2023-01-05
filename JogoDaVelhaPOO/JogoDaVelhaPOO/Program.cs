using JogoDaVelhaPOO.Entities;

namespace JogoDaVelhaPOO;

class Program
{
    static void Main(string[] args)
    {
        int verificador = 0;

        while(verificador == 0) 
        {
            Console.Clear(); 
            Tabuleiro.ImprimirTabuleiro();

            Console.Write("\nInforme a posição da linha que deseja jogar: ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("\nInforme a posição da coluna que deseja jogar: ");
            int coluna = int.Parse(Console.ReadLine());
            
            Jogadas.RealizarJogada(linha, coluna);

            VerificarCondicoes verificarCondicoes= new VerificarCondicoes();
            int verificar = verificarCondicoes.VerificarLinhas(); 
            if(verificar == 1)
            {
                Console.WriteLine("\nO Player X venceu!"); 
                verificador++; 
            }
            else if(verificar == 2)
            {
                Console.WriteLine("\nO Player O venceu!");  
                verificador++;
            }
            verificar = verificarCondicoes.VerificarColunas();
            if (verificar == 1)
            {
                Console.WriteLine("\nO Player X venceu!"); 
                verificador++;
            }
            else if (verificar == 2)
            {
                Console.WriteLine("\nO Player O venceu!"); 
                verificador++;
            }
            verificar = verificarCondicoes.VerificarDiagonais();
            if (verificar == 1)
            {
                Console.WriteLine("\nO Player X venceu!");
                verificador++;
            }
            else if (verificar == 2)
            {
                Console.WriteLine("\nO Player O venceu!");
                verificador++;
            }

            Tabuleiro.ImprimirTabuleiro();
        }
    }
}
