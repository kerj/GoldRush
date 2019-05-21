using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Player
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int PlayerGold { get; set; }


    //player, getter/setter .. name

    public PLayer( string name, int playerGold, int id = 0)
    {
      Id = id;
      Name = name;
      PlayerGold = playerGold;
    }

    public static Player Find(int playerId)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM players WHERE id = @playerId;";
      cmd.Parameters.AddWithValue("@playerId", playerId);
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      rdr.Read();
      int id = rdr.GetInt32(0);
      string name = rdr.GetString(1);
      int playerGold = rdr.GetString(2);
      Player foundPlayer = new Player(name, playerGold, id);
      conn.Close();
      return foundPlayer;
    }

    public static List<Player> GetAll()
    {
      List<Player> allPlayers = new List<Player> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM players;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {

        int id = rdr.GetInt32(0);
        string playerName = rdr.GetString(1);
        int playerGold = rdr.GetString(2);
        Player newPlayer = new Player(playerName, playerGold, id);
        allPlayers.Add(newPlayer);
      }
      conn.Close();
      return allPlayers;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO players (name, player_gold) VALUES (@playerName, @playerGold);";
      cmd.Parameters.AddWithValue("@playerName", this.Name);
      cmd.Parameters.AddWithValue("@playerGold", this.PlayerGold);
      cmd.ExecuteNonQuery();
      this.Id = (int) cmd.LastInsertedId;
      conn.Close();
    }
    // public static void AssignBoard(int playerId, int boardId)
    // {
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   var cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"INSERT INTO player_boards (player_id, board_id) VALUES (@playerId, @boardId);";
    //   cmd.Parameters.AddWithValue("@playerId", playerId);
    //   cmd.Parameters.AddWithValue("@boardId", boardId);
    //   cmd.ExecuteNonQuery();
    //   conn.Close();
    // }
  }
}
