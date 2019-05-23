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
    public int GoldCount {get; set;}
    public int TntCount {get; set;}

    public Square(int id, int squareType, int xposition, int yposition, bool clicked, int goldCount, int tntCount)
    {
      Id = id;
      SquareType = squareType;
      Xposition = xposition;
      Yposition = yposition;
      Clicked = clicked;
      GoldCount = goldCount;
      TntCount = tntCount;
    }

    public static List<Square> TypeOfSquare()
    {
      Random rnd = new Random();
      int goldCount = 0;
      int tntCount = 0;

      List<Square> allSquares = new List<Square> {};
      for(int i = 0; i < 10; i++)
      {
        for(int j = 0; j < 10; j++)
        {
          int squareType = rnd.Next(-1,11);
          if(goldCount > 8)
          {
            squareType = rnd.Next(1,3);
          }
          if(tntCount > 8)
          {
            squareType = rnd.Next(0,3);
            if(goldCount == 8 && squareType == 10)
            {
              squareType++;
            }
          }
          if (squareType == 10)
          {
            goldCount++;
          }
          if(squareType == -1)
          {
            tntCount++;
          }
          int id = allSquares.Count;

          Square newSquare = new Square(id, squareType, i, j, false, goldCount, tntCount);
          allSquares.Add(newSquare);
        }
      }
      return allSquares;
    }
  }
}
