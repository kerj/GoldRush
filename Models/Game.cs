using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Game
  {
<<<<<<< HEAD
    public List<Player> newPlayer { get; set; }
    public List<Prospector> theProspector { get; set; }
    public List<Board> newBoard { get; set; }
=======
    public Player newPlayer { get; set; }
    public Prospector theProspector { get; set; }
    public Board newBoard { get; set; }
>>>>>>> 0bc564782401619c4ae95ea2168260d57e391bdb
    //player, getter/setter .. name
  }
}
