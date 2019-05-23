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
      Dictionary<string, object> playerData = new Dictionary<string, object> {};
      Player player = new Player(name);
      player.Save();
      playerData.Add("NewPlayer", player);
      List<Player> viewPlayers = Player.GetAll();
      playerData.Add("PlayerList", viewPlayers);
      return View(playerData);
    }

    [HttpGet("/game/highscores")]
    public ActionResult highscores()
    {
      Dictionary<string, object> playerData = new Dictionary<string, object> {};
      List<Player> viewPlayers = Player.GetAll();
      playerData.Add("PlayerList", viewPlayers);
      return View(playerData);
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
