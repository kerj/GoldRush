using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Board
  {
    public int Id { get; set; }
    public int Xaxis { get; set; }
    public int Yaxis { get; set; }
    public bool Gold { get; set; }
    public bool Tnt { get; set; }

    public Board(int xaxis, int yaxis, bool gold, bool tnt, int id = 0)
    {
      Id = id;
      Xaxis = xaxis;
      Yaxis = yaxis;
      Gold = gold;
      Tnt = tnt;
    }

    public void BuildBoard()
    {
      int xaxis = 10;
      int yaxis = 10;
      bool gold = false;
      bool tnt = false;

      Board newGame = new Board(xaxis, yaxis, gold, tnt);
      Random rand = new Random();
      MySqlConnection conn = DB.Connection();
      conn.Open();
      for(int i = 1; i < xaxis+1; i++)
      {
        for(int j = 1; j < yaxis+1; i++)
        {
          MySqlCommand cmd = new MySqlCommand(@"INSERT INTO boards (x_axis, y_axis) VALUES (@Xaxis, Yaxis);", conn);
          cmd.Parameters.AddWithValue("@Xaxis", i);
          cmd.Parameters.AddWithValue("@Yaxis", j);
          cmd.ExecuteNonQuery();
          Id = (int) cmd.LastInsertedId;
        }
      }
      for(int x = 0; x < 5; x++)
      {
        xaxis = rand.Next(0, 10);
        yaxis = rand.Next(0, 10);
        MySqlCommand command = new MySqlCommand(@"UPDATE boards SET tnt = @true WHERE x_axis = @xaxis AND y_axis = @yaxis;", conn);

        command.Parameters.AddWithValue("@xaxis", xaxis);
        command.Parameters.AddWithValue("@yaxis", yaxis);
        command.Parameters.AddWithValue("@true", true);

        command.ExecuteNonQuery();

      }

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }



    public static List<GameBoard> GetAll()
    {
      List<GameBoard> newGame = new List<GameBoard> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM board;", conn);
      MySqlDataReader rdr = cmd. ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int BoardId = rdr.GetInt32(0);
        int BoardXaxis = rdr.GetInt32(1);
        int BoardYaxis = rdr.GetInt32(2);
        bool BoardGold = rdr.GetBoolean(3);
        bool BoardTnt = rdr.GetBoolean(4);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return newGame;
    }

    // MySqlCommand command = new MySqlCommand(@"INSERT INTO boards (gold) VALUES (@Gold)", conn);
    // command.Parameters.AddWithValue("@Gold", this.gold);

  }
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
}
