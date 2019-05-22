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
      Player player = new Player(name);
      return View(player);
    }



    // [HttpGet("/game")]
    // public ActionResult Index()
    // {
    //   List<Square> newSquareList = Square.TypeOfSquare();
    //   return View(newSquareList);
    // }

  }
}
