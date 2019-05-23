using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoldRush.Models;

namespace GoldRush.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> playerData = new Dictionary<string, object> {};
      List<Player> viewPlayers = Player.GetAll();
      playerData.Add("PlayerList", viewPlayers);
      return View(playerData);
    }
  }
}
