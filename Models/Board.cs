using System.Collections.Generic;
using System;
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

      Dictionary<int, int> goldPlots = new Dictionary{};
      Dictionary<int, int> tntPlots = new Dictionary{};

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
      for(int x = 0; x < 8; x++)
      {
        GoldXaxis = rand.Next(0, 10);
        GoldYaxis = rand.Next(0, 10);
        TntXaxis = rand.Next(0, 10);
        TntYaxis = rand.Next(0, 10);

        foreach (var item in goldPlots)
        {
          foreach (var bomb in tntPlots)
          {
            while (bomb.TntXaxis == TntXaxis && bomb.TntYaxis == TntYaxis || TntXaxis == item.GoldXaxis && TntYaxis == item.GoldYaxis)
            {
              TntXaxis = rand.Next(0, 10);
              TntYaxis = rand.Next(0, 10);
            }
            tntPlots.Add(TntXaxis, TntYaxis);
          }
          foreach (var bomb in tntPlots)
          {
            while (item.GoldXaxis == GoldXaxis && item.GoldYaxis == GoldYaxis || GoldXaxis == bomb.TntXaxis && GoldYaxis == bomb.TntYaxis)
            {
              GoldXaxis = rand.Next(0, 10);
              GoldYaxis = rand.Next(0, 10);
            }
            goldPlots.Add(GoldXaxis, GoldYaxis);
          }
        }

        MySqlCommand command = new MySqlCommand(@"UPDATE boards SET tnt = @true WHERE x_axis = @TntXaxis AND y_axis = @TntYaxis; UPDATE boards SET gold = @true WHERE x_axis = @GoldXaxis AND y_axis = @GoldYaxis;", conn);

        command.Parameters.AddWithValue("@GoldXaxis", GoldXaxis);
        command.Parameters.AddWithValue("@GoldYaxis", GoldYaxis);
        command.Parameters.AddWithValue("@TntXaxis", TntXaxis);
        command.Parameters.AddWithValue("@TntYaxis", TntYaxis);
        command.Parameters.AddWithValue("@true", true);

        command.ExecuteNonQuery();

      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static List<Board> GetAll()
    {
      List<Board> newGame = new List<Board> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM board;", conn);
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
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

    public static Board CheckForTnt(int boardId)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = new MySqlCommand(@"SELECT tnt FROM boards WHERE id = @boardId;", conn);
      cmd.Parameters.AddWithValue("@boardId", boardId)
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      rdr.Read()
      int BoardId = rdr.GetInt32(0);
      int BoardXaxis = rdr.GetInt32(1);
      int BoardYaxis = rdr.GetInt32(2);
      bool BoardGold = rdr.GetBoolean(3);
      bool BoardTnt = rdr.GetBoolean(4);
      Board checkForTnt = new Board(BoardXaxis, BoardYaxis, BoardGold, BoardTnt, BoardId);

      conn.Close()
      if (conn != null)
      {
        conn.Dispose();
      }
      return checkForTnt.BoardTnt;
    }


  public static Board CheckForGold(int boardId)
  {
    MySqlConnection conn = DB.Connection();
    conn.Open();
    MySqlCommand cmd = new MySqlCommand(@"SELECT gold FROM boards WHERE id = @boardId;", conn);
    cmd.Parameters.AddWithValue("@boardId", boardId)
    MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    rdr.Read()
    int BoardId = rdr.GetInt32(0);
    int BoardXaxis = rdr.GetInt32(1);
    int BoardYaxis = rdr.GetInt32(2);
    bool BoardGold = rdr.GetBoolean(3);
    bool BoardTnt = rdr.GetBoolean(4);
    Board checkForGold = new Board(BoardXaxis, BoardYaxis, BoardGold, BoardTnt, BoardId);

    conn.Close()
    if (conn != null)
    {
      conn.Dispose();
    }
    return checkForGold.BoardGold;
  }

  public static void Counter(bool count)
  {
    MySqlConnection conn = DB.Connection();
    conn.Open();
    MySqlCommand cmd = new MySqlCommand(@"SELECT players.player_gold FROM boards JOIN players_boards ON (boards.id = players_boards.board_id) JOIN players ON (players_boards.player_id = players.id);", conn);
    MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    while(rdr.Read());
    {
      int PlayerBoardId = rdr.GetInt32(0);
      int PlayerId = rdr.GetInt32(1);
      int BoardId = rdr.GetInt32(2);
    }


    if (count == true)
    {
      playerGold++;
      gold--;
    }
    else()
    {
      playerTurn--;
    }

    conn.Close();
    if(conn != null)
    {
      conn.Dispose();
    }
  }

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
