using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Prospector
  {
    public int Id { get; set; }
    public string Phrase { get; set; }
    public bool win { get; set; }
    public bool lose { get; set; }
    public bool intro { get; set; }
    //player, getter/setter .. name
  }
}
