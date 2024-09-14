using Microsoft.AspNetCore.Mvc;

namespace CajeroWeb.Controllers
{
	public class MenuController : Controller
	{
		// GET: Menu
		public ActionResult Menu(string sNumeroTarjeta, double sSaldo)
		{
			ViewBag.sNumeroTarjeta = sNumeroTarjeta;
			ViewBag.sSaldo = sSaldo;
			return View();
		}
	}
}
