using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoldRush.Models;

namespace GoldRush.Controllers
{
  public class GameController : Controller
  {

    [HttpPost("/game/player")]
    public ActionResult Rules(string name)
    {
      Player player = new Player(name);
      return View(player);
    }

    [HttpGet("/game/start")]
    public ActionResult Index()
    {
      List<Square> newSquares = Square.TypeOfSquare();
      Board newSquareList = new Board();
      return View(newSquares);
    }

    [HttpGet("/game/lostgamemoves")]
    public ActionResult lostgamemoves()
    {
      return View();
    }

    [HttpGet("/game/wongame")]
    public ActionResult wongame()
    {
      return View();
    }

    [HttpGet("/game/new")]
    public ActionResult New()
    {
      return RedirectToAction("Index", "Home");
    }


    [HttpGet("/lose")]
    public ActionResult LostGameTnt()
    {
      return View();
    }

  }
}
