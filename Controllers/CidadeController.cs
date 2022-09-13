using Microsoft.AspNetCore.Mvc;

namespace teste_curso_mvc.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
