using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoldRush.Models;

namespace GoldRush.Controllers
{
  public class GameController : Controller
  {

    [HttpGet("/game")]
    public ActionResult Index()
    {
      Game newGame = new Game();
      List<Board> newBoard = Board.GetAll();
      List<Player> newPlayer = Player.GetAll();
      List<Prospector> theProspector = Prospector.GetAll();
      return View(newGame);
    }

  }
}
