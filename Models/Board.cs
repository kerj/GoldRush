using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Board
  {
    public bool TntCheck { get; set; }
    public Board()
    {
      TntCheck = false;
    }
  }
}
