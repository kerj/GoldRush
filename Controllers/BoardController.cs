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



    // [HttpGet("/")]
    // public ActionResult Index()
    // {
    //   Board newGame = new Board(0,0,false,false,0);
    //   newGame.BuildBoard();
    //   List<Board> newBoard = Board.GetAll();
    //   return View(newBoard);
    // }

  }
}
