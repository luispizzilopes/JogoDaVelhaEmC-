namespace JogoDaVelhaPOO.Entities
{
    internal class VerificarCondicoes
    {
        private int verificador; 

        public int VerificarLinhas()
        {
            int contadorDeX = 0;
            int contadorDeO = 0; 

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Tabuleiro.tabuleiroDoJogo[i,j] == 'X') 
                    {
                        contadorDeX++; 
                    }
                    else if (Tabuleiro.tabuleiroDoJogo[i,j] == 'O')
                    {
                        contadorDeO++; 
                    }
                }

                if (contadorDeX == 3)
                {
                    return 1; 
                }
                else if(contadorDeO == 3)
                {
                    return 2; 
                }

                contadorDeX = 0;
                contadorDeO = 0;
            }

            return 0; 
        }

        public int VerificarColunas()
        {
            int contadorDeX = 0;
            int contadorDeO = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Tabuleiro.tabuleiroDoJogo[j, i] == 'X')
                    {
                        contadorDeX++;
                    }
                    else if (Tabuleiro.tabuleiroDoJogo[j, i] == 'O')
                    {
                        contadorDeO++;
                    }
                }

                if (contadorDeX == 3)
                {
                    return 1;
                }
                else if (contadorDeO == 3)
                {
                    return 2;
                }

                contadorDeX = 0;
                contadorDeO = 0;
            }

            return 0;
        }

        public int VerificarDiagonais()
        {
            if ((Tabuleiro.tabuleiroDoJogo[0, 0] == 'X' && Tabuleiro.tabuleiroDoJogo[1, 1] == 'X' && Tabuleiro.tabuleiroDoJogo[2, 2] == 'X')
                || (Tabuleiro.tabuleiroDoJogo[0, 2] == 'X' && Tabuleiro.tabuleiroDoJogo[1, 1] == 'X' && Tabuleiro.tabuleiroDoJogo[2, 0] == 'X'))
            {
                return 1;
            }
            else if ((Tabuleiro.tabuleiroDoJogo[0, 0] == 'Y' && Tabuleiro.tabuleiroDoJogo[1, 1] == 'Y' && Tabuleiro.tabuleiroDoJogo[2, 2] == 'Y')
                || (Tabuleiro.tabuleiroDoJogo[0, 2] == 'Y' && Tabuleiro.tabuleiroDoJogo[1, 1] == 'Y' && Tabuleiro.tabuleiroDoJogo[2, 0] == 'Y'))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
