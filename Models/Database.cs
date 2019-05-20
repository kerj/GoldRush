using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using GoldRush;

namespace GoldRush.Models
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }
  }
}
