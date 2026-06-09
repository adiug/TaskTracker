using Microsoft.AspNetCore.Mvc; 

public class TasksController : Controller {

  private static List<string> _tasks = new()  { "Buy groceries", "Read a book"    }; 
  public IActionResult Index()   { return View(_tasks);    }
  public IActionResult Create()  { return View();    }

   [HttpPost] 
  public IActionResult Create(string title)    { 
    if (!string.IsNullOrWhiteSpace(title))  {  _tasks.Add(title); } 
    return RedirectToAction(nameof(Index));    
  }
}
