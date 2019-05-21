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
  }
}
