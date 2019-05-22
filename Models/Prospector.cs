using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  // public class Prospector
  // {
  //   public int Id { get; set; }
  //   public string Phrase { get; set; }
  //   public bool Win { get; set; }
  //   public bool Lose { get; set; }
  //   public bool Intro { get; set; }
  //
  //   public Prospector( string phrase, bool win, bool lose, bool intro, int id = 0)
  //   {
  //     Id = id;
  //     Phrase = phrase;
  //     Win = win;
  //     Lose = lose;
  //     Intro = intro;
  //   }
  //
  //   public static List<Prospector> GetAll()
  //   {
  //     List<Prospector> allProspectors = new List<Prospector> {};
  //     MySqlConnection conn = DB.Connection();
  //     conn.Open();
  //     MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
  //     cmd.CommandText = @"SELECT * FROM prospectors;";
  //     MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
  //     while(rdr.Read())
  //     {
  //
  //       int id = rdr.GetInt32(0);
  //       string playerName = rdr.GetString(1);
  //       bool win = rdr.GetBoolean(2);
  //       bool lose = rdr.GetBoolean(3);
  //       bool intro = rdr.GetBoolean(4);
  //       Prospector newProspector = new Prospector(phrase, win, lose, intro, id);
  //       allProspectors.Add(newProspector);
  //     }
  //     conn.Close();
  //     return allProspectors;
  //   }
  // }
}
