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
    public bool TntCheck { get; set; }


    public Player( string name, int playerGold = 0, int id = 0)
    {
      Id = id;
      Name = name;
      PlayerGold = playerGold;
    }
  }
}
