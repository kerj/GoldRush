using Microsoft.AspNetCore.Mvc;

namespace GoldRush.Controllers
{
  public class GameController : Controller
  {

    [HttpGet("/goldrush")]
    public ActionResult Index()
    {
      return View();
    }

  }
}
