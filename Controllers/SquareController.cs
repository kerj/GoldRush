using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoldRush.Models;

namespace GoldRush.Controllers
{
  public class SquareController : Controller
  {

    [HttpGet("/square")]
    public ActionResult Index()
    {
      Board newSquareList = new Board();
      return View(Board.newSquares);
    }

  }
}
