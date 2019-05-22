using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace GoldRush.Models
{
  public class Square
  {
    public int Id { get; set;}
    public int SquareType { get; set; }
    public int Xposition { get; set; }
    public int Yposition { get; set; }
    public bool Clicked { get; set; }

    public Square(int id, int squareType, int xposition, int yposition, bool clicked)
    {
      Id = id;
      SquareType = squareType;
      Xposition = xposition;
      Yposition = yposition;
      Clicked = clicked;
    }

    public static List<Square> TypeOfSquare()
    {
      Random rnd = new Random();
      int gold = 0;
      int tnt = 2;
      int nothing = 1;
      int goldCount = 0;
      int tntCount = 0;

      List<Square> allSquares = new List<Square> {};
      for(int i = 0; i < 10; i++)
      {
        for(int j = 0; j < 10; j++)
        {
          if(goldCount > 8)
          {
            rnd.Next(1,2);
          }
          if(tntCount > 8)
          {
            rnd.Next(0,1);
          }
          int squareType = rnd.Next(0,2);
          if (squareType == 0)
          {
            goldCount++;
          }
          if(squareType == 2)
          {
            tntCount++;
          }
          int id = allSquares.Count;

          Square newSquare = new Square(id, squareType, i, j, false);
          allSquares.Add(newSquare);
        }
      }
      return allSquares;
    }
  }
}
