using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe_Project
{
    class AllMethodForTicTacToe
    {
        public int chance,flage=5,index;
        public char[] arry = { '0', '1', '2', '3','4','5','6','7','8','9' };
        public void PlayerSelection()
        {
            Random random = new Random();
            switch (random.Next(0, 2))
            {
                case 0:
                    Console.WriteLine("Player 1 will start the Game:  ");
                    Console.WriteLine("Player 1 symbol is X ");
                    chance = 1;
                    break;
                case 1:
                    Console.WriteLine("Player 2 will start the Game:   ");
                    Console.WriteLine("Player 2 symbol is O  ");
                    chance = 2;
                    break;
            }
        }
        public int CheckWinOrDraw()
        {
            if ((arry[1] == arry[2] && arry[2] == arry[3] && arry[3] == 'X') ||
                (arry[4] == arry[5] && arry[5] == arry[6] && arry[6] == 'X') ||
                (arry[7] == arry[8] && arry[8] == arry[9] && arry[9] == 'X') ||
                (arry[1] == arry[4] && arry[4] == arry[7] && arry[7] == 'X') ||
                (arry[2] == arry[5] && arry[5] == arry[8] && arry[8] == 'X') ||
                (arry[3] == arry[6] && arry[6] == arry[9] && arry[9] == 'X') ||
                (arry[1] == arry[5] && arry[5] == arry[9] && arry[9] == 'X'))
            {
                return 1;

            }
            else if ((arry[1] == arry[2] && arry[2] == arry[3] && arry[3] == 'O') ||
                   (arry[4] == arry[5] && arry[5] == arry[6] && arry[6] == 'O') ||
                   (arry[7] == arry[8] && arry[8] == arry[9] && arry[9] == 'O') ||
                   (arry[1] == arry[4] && arry[4] == arry[7] && arry[7] == 'O') ||
                   (arry[2] == arry[5] && arry[5] == arry[8] && arry[8] == 'O') ||
                   (arry[3] == arry[6] && arry[6] == arry[9] && arry[9] == 'O') ||
                   (arry[1] == arry[5] && arry[5] == arry[9] && arry[9] == 'O'))
            {
                return 2;
            }
            else if (arry[1] != '1' && arry[2] != '2' 
                    && arry[3] != '3' && arry[4] != '4'
                    && arry[5] != '5' && arry[6] != '6' 
                    && arry[7] != '7' && arry[8] != '8' 
                    && arry[9] != '9')
            {
                return 0;
            }
            return flage;
        }
        public void WhichPlayerWon()
        {
            if (flage == 1)
            {
                Console.WriteLine("Player 1 has Won the Game  ");
            }else if (flage == 2)
            {
                Console.WriteLine("Player 2 has Won the Game  ");
            }
            else if (flage == 0)
            {
                Console.WriteLine("No Player Won:::::::Game is Draw ");
            }
        }
        public void GamePlay()
        {
            flage = 5;
            do
            {
                DrawBoard();

                if (chance % 2 == 0)
                {
                    Console.WriteLine("Player 2 Should make Selection");
                    index = Convert.ToInt32(Console.ReadLine());
                    if (index <= 9 && index >= 1)
                    {
                        if (arry[index] != 'X' && arry[index] != 'O')
                        {
                            arry[index] = 'O';
                            Console.WriteLine("Player 2 made right selection recorded");
                            chance++;
                            flage = CheckWinOrDraw();
                        }
                        else if (arry[index] == 'X' || arry[index] == 'O')
                        {
                            Console.WriteLine("Player 2 is making wrong selection\nPosition already occupied" + arry[index]);
                        }
                    }
                    else { Console.WriteLine("Player input is invalid"); }
                }
                else if (chance % 2 == 1)
                {
                    Console.WriteLine("Player 1 Should make Selection");
                    index = Convert.ToInt32(Console.ReadLine());
                    if (index <= 9 && index >= 1)
                    {
                        if (arry[index] != 'X' && arry[index] != 'O')
                        {
                            arry[index] = 'X';
                            Console.WriteLine("Player 1 made right selection recorded");
                            chance++;
                            flage = CheckWinOrDraw();
                        }
                        else if (arry[index] == 'X' || arry[index] == 'O')
                        {
                            Console.WriteLine("Player 1 is making wrong selection\nPosition already occupied" + arry[index]);
                        }
                    }
                    else { Console.WriteLine("Player input is invalid"); }
                }
            } while (flage != 1 && flage != 0);
        }
        public void DrawBoard()
        {
            Console.WriteLine("| "+arry[1]+" |"+arry[2]+" |"+arry[3]+" |");
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("\n| "+arry[4]+" |"+arry[5]+" |"+arry[6]+" |");
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("\n| "+arry[7]+" |"+arry[8]+" |"+arry[9]+" |");
            Console.WriteLine("\n-----------------------------------------");
        }

    }
}
