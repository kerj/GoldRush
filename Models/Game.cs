using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Game
  {
    public List<Player> newPlayer { get; set; }
    // public List<Prospector> theProspector { get; set; }
    public List<Board> newBoard { get; set; }
    //player, getter/setter .. name
  }
}
