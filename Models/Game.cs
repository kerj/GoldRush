using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Game
  {
    public Player newPlayer { get; set; }
    public Prospector theProspector { get; set; }
    public Board newBoard { get; set; }
    //player, getter/setter .. name
  }
}
