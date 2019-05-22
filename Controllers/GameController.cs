using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoldRush.Models;

namespace GoldRush.Controllers
{
  public class GameController : Controller
  {

    [HttpPost("/game/name/new")]
    public ActionResult Rules(string name)
    {
      Board newSquareList = new Board();
      return View(Board.newSquares);
    }

    // [HttpGet("/game")]
    // public ActionResult Index()
    // {
    //   List<Square> newSquareList = Square.TypeOfSquare();
    //   return View(newSquareList);
    // }

  }
}
