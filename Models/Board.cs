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

    public Board(int xaxis, int yaxis)
    {
      Xaxis = xaxis;
      Yaxis = yaxis;
    }

    public void BuildBoard()
    {
      int xaxis = 10;
      int yaxis = 10;
      Board newGame = new Board(xaxis, yaxis);
      MySqlConnection conn = DB.Connection();
      conn.Open();
      for(int i = 1; i < xaxis+1; i++)
      {
        for(int j = 1; j < yaxis+1; i++)
        {
          MySqlCommand cmd = new MySqlCommand(@"INSERT INTO boards (x_axis, y_axis) VALUES (@Xaxis, Yaxis)", conn);
          cmd.Parameters.AddWithValue("@Xaxis", i);
          cmd.Parameters.AddWithValue("@Yaxis", j);
          Id = (int) cmd.LastInsertedId;
        }
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

  }
}
