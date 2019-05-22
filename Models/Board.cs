using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Board
  {
    // public static List<Square> newSquares = Square.TypeOfSquare();
    // public List<Player> newPlayers = Player.GetAll();
    public bool TntCheck { get; set; }
    public Board()
    {
      TntCheck = false;
    }

    // public static int CheckSquare(int squareType, int id, int goldCount)
    // {
    //   int goldCounter = 0;
    //
    //   if (newSquares[id].SquareType == 10)
    //   {
    //     goldCounter++;
    //   }
    //   return goldCounter;
    // }



    // public Board BuildBoard()
    // {
    //   Board newGame = new Board(xaxis, yaxis, gold, tnt);
    //   int goldCount = 0;
    //   int tntCount = 0;
    //   Random rand = new Random();
    //   int[,] newGame = new int[10,10];
    //   for(int i = 0; i < newGame.GetLength(0); i++)
    //   {
    //     for(int j = 0; j < newGame.GetLength(1); i++)
    //     {
    //       if(goldCount > 8)
    //       {
    //         rand.Next(1,2);
    //       }
    //       if(tntCount > 8)
    //       {
    //         rand.Next(0,1);
    //       }
    //       newGame[i,j] = rand.Next(0,2);
    //       if(newGame[i,j] == 0)
    //       {
    //         goldCount++;
    //       }
    //       if(newGame[i,j] == 2)
    //       {
    //         tntCount++;
    //       }
    //     }
    //   }
    //   return newGame;
    // }
  }
}
