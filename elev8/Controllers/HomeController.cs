using elev8.DataAccess;
using elev8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace elev8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITodoRepository _todoRepository;

        public HomeController(ILogger<HomeController> logger, ITodoRepository todo)
        {
            _logger = logger;
            _todoRepository = todo;
        }

        public IActionResult Index()
        {
            /*Todo t = new Todo() { Desc = "test2",  IsComplete = true };
            _todoRepository.Add(t);*/
            return View(_todoRepository.GetAll());
        }

        [HttpPost]
        public JsonResult Add(string todo)
        {
            //_todoRepository.AddByDesc(todo);
            return Json( _todoRepository.AddByDesc(todo));
            ///return View("Index",_todoRepository.AddByDesc(todo));
        }

        [HttpPost]
        public JsonResult Change(int id)
        {
            return Json(_todoRepository.ChangeChecked(id));
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            _todoRepository.DeleteById(id);
            return Json("deleted");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}