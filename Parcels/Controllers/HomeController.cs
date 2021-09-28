using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/cost")]
    public ActionResult Cost()
    {
      return View();
    }

    [HttpPost("/cost")]
    public ActionResult Cost(int weight, int length, int height, int width)
    {
      Parcel myParcel = new Parcel(weight, length, height, width);
      myParcel.GetVolume();
      myParcel.GetCost();
      return View(myParcel);
    }
  }
}