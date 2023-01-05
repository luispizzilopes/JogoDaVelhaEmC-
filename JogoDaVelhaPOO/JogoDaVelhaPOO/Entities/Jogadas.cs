using System;
using System.Collections.Generic;
namespace JogoDaVelhaPOO.Entities
{
    internal class Jogadas
    {
        private static bool verificador = false; 

        public static void RealizarJogada(int x, int y)
        {
            if(verificador == false && Tabuleiro.tabuleiroDoJogo[x,y] == '*')
            {
                Tabuleiro.tabuleiroDoJogo[x, y] = 'X';
                verificador = true;
            }
            else if(verificador == true && Tabuleiro.tabuleiroDoJogo[x, y] == '*')
            {
                Tabuleiro.tabuleiroDoJogo[x, y] = 'O';
                verificador = false; 
            }
            
        }
    }
}
