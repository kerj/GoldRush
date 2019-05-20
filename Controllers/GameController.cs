using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoldRush.Models;

namespace GoldRush.Controllers
{
  public class GameController : Controller
  {

    [HttpGet("/goldrush")]
    public ActionResult Index()
    {
      List<Board> newGameBoard = Board.GetAll();
      return View(newGameBoard);
    }

  }
}
