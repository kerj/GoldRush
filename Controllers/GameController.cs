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

    [HttpGet("/lose")]
    public ActionResult LostGameMoves(string name)
    {

      return View();
    }

    [HttpGet("/lose/tnt")]
    public ActionResult LostGameTnt(string name)
    {

      return View();
    }
    [HttpGet("/won")]
    public ActionResult WonGame(string name)
    {

      return View();
    }

    // [HttpGet("/game")]
    // public ActionResult Index()
    // {
    //   List<Square> newSquareList = Square.TypeOfSquare();
    //   return View(newSquareList);
    // }

  }
}
