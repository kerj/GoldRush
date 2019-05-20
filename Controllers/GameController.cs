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
      return View("Index");
    }

  }
}
