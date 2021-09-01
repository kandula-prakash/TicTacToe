using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class Chooseletter
    {
        public static void chooseLetter()
        {
            char letter;
            Console.WriteLine("choose a letter X or O");
            letter = Console.ReadLine()[0];


            if (letter == 'X')
            {
                Console.WriteLine("player's letter is X. ");
                Console.WriteLine("Computer's letter is O.");

            }
            else if (letter == 'O')
            {
                Console.WriteLine("player's letter is O.");
                Console.WriteLine("Computer's letter is X.");
            }
            else
            {
                Console.WriteLine("Error. you have to choose X or O only");
            }
        }
    }
}