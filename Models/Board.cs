using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Board
  {
    public int Id { get; set; }
    public int Gold { get; set; }
    public int Tnt { get; set; }

    public Board( int id, int gold, int tnt)
    {
      Id = id;
      Gold = gold;
      Tnt = tnt;
    }

    // public Board BuildBoard()
    // {
      // Board newGame = new Board(xaxis, yaxis, gold, tnt);
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
