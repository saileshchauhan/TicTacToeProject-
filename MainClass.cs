using System;

namespace Tic_Tac_Toe_Project
{
    class MainClass
    {
        static void Main(string[] args)
        {
            AllMethodForTicTacToe allMethodForTic = new AllMethodForTicTacToe();

            allMethodForTic.PlayerSelection();
         
               
            allMethodForTic.GamePlay();

            allMethodForTic.WhichPlayerWon();

            allMethodForTic.DrawBoard();

           
        }
    }
}
