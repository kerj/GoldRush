using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Gold
  {
    public int Id { get; set; }
    public bool Gold { get; set; }

    public Gold(int id, bool gold)
    {
      Id = id;
      Gold = gold;
    }

    public void SetGold()
    {
      Gold newGameGold = new Gold(id, gold);
    }

  }
  public class Tnt
  {
    public int Id { get; set; }
    public bool Tnt { get; set; }

    public Tnt(int id, bool tnt)
    {
      Id = id;
      Tnt = tnt;
    }


  }
}
