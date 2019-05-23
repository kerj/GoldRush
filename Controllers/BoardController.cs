using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoldRush.Models;

namespace GoldRush.Controllers
{
  public class BoardController : Controller
  {

    [HttpGet("/board")]
    public ActionResult Board()
    {
      List<Square> board = Square.TypeOfSquare();
      return View(board);
    }
  }
}
