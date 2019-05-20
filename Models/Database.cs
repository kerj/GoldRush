using System;
using MySql.Data.MySqlClient;
using GoldRush;
using System.Collections.Generic;

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
