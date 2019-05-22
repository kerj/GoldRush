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



//     public static List<Board> GetAll()
//     {
//       List<Board> newGame = new List<Board> {};
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM board;", conn);
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       while(rdr.Read())
//       {
//         int BoardId = rdr.GetInt32(0);
//         int BoardXaxis = rdr.GetInt32(1);
//         int BoardYaxis = rdr.GetInt32(2);
//         bool BoardGold = rdr.GetBoolean(3);
//         bool BoardTnt = rdr.GetBoolean(4);
//       }
//
//       conn.Close();
//       if (conn != null)
//       {
//         conn.Dispose();
//       }
//       return newGame;
//     }
//
//     public static Board CheckForTnt(int boardId)
//     {
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = new MySqlCommand(@"SELECT tnt FROM boards WHERE id = @boardId;", conn);
//       cmd.Parameters.AddWithValue("@boardId", boardId);
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       rdr.Read();
//       int BoardId = rdr.GetInt32(0);
//       int BoardXaxis = rdr.GetInt32(1);
//       int BoardYaxis = rdr.GetInt32(2);
//       bool BoardGold = rdr.GetBoolean(3);
//       bool BoardTnt = rdr.GetBoolean(4);
//       Board checkForTnt = new Board(BoardXaxis, BoardYaxis, BoardGold, BoardTnt, BoardId);
//
//       conn.Close();
//       if (conn != null)
//       {
//         conn.Dispose();
//       }
//       return checkForTnt.BoardTnt;
//     }
//
//
//   public static Board CheckForGold(int boardId)
//   {
//     MySqlConnection conn = DB.Connection();
//     conn.Open();
//     MySqlCommand cmd = new MySqlCommand(@"SELECT gold FROM boards WHERE id = @boardId;", conn);
//     cmd.Parameters.AddWithValue("@boardId", boardId);
//     MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//     rdr.Read();
//     int BoardId = rdr.GetInt32(0);
//     int BoardXaxis = rdr.GetInt32(1);
//     int BoardYaxis = rdr.GetInt32(2);
//     bool BoardGold = rdr.GetBoolean(3);
//     bool BoardTnt = rdr.GetBoolean(4);
//     Board checkForGold = new Board(BoardXaxis, BoardYaxis, BoardGold, BoardTnt, BoardId);
//
//     conn.Close();
//     if (conn != null)
//     {
//       conn.Dispose();
//     }
//     return checkForGold.BoardGold;
//   }
//
//   public static void Counter(bool count)
//   {
//     MySqlConnection conn = DB.Connection();
//     conn.Open();
//     MySqlCommand cmd = new MySqlCommand(@"SELECT players.player_gold FROM boards JOIN players_boards ON (boards.id = players_boards.board_id) JOIN players ON (players_boards.player_id = players.id);", conn);
//     MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//     while(rdr.Read());
//     {
//       int PlayerBoardId = rdr.GetInt32(0);
//       int PlayerId = rdr.GetInt32(1);
//       int BoardId = rdr.GetInt32(2);
//     }
//
//
//     if (count == true)
//     {
//       playerGold++;
//       gold--;
//     }
//     else
//     {
//       playerTurn--;
//     }
//
//     conn.Close();
//     if(conn != null)
//     {
//       conn.Dispose();
//     }
//   }
//
// }
  // public class Gold
  // {
  //   public int Id { get; set; }
  //   public bool Gold { get; set; }
  //
  //   public Gold(int id, bool gold)
  //   {
  //     Id = id;
  //     Gold = gold;
  //   }
  //
  //   public void SetGold()
  //   {
  //     Gold newGameGold = new Gold(id, gold);
  //   }
  //
  // }
  // public class Tnt
  // {
  //   public int Id { get; set; }
  //   public bool Tnt { get; set; }
  //
  //   public Tnt(int id, bool tnt)
  //   {
  //     Id = id;
  //     Tnt = tnt;
  //   }
  //
  //
  // }
