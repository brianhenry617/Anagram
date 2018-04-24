using System.Collections.Generic;
using Microsoft.AspNetCore.mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
  public class AnagramController : Controller
  {
    [httpGet("/Anagram")]
    public ActionResult Index()
    {
      List<Word> allwords = Word.GetAll();
      return View(allwords);
    }
  }
}
