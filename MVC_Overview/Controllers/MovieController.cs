using Microsoft.AspNetCore.Mvc;
using MVC_Overview.Models;
using System.Net.Mime;
using System.Security.Cryptography.Xml;

namespace MVC_Overview.Controllers
{
    // MVC Controller
    public class MovieController : Controller
    {
        // Actions : public non-static method
        // Actions : Has Special Return Type
        // ActionResult

        //public string GetMovie(int id)
        //{
        //    return $"Get Movie With Id: {id}";
        //}
        //public string AddtMovie(int id)
        //{
        //    return $"Add Movie With Id: {id}";
        //}


        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With Id: {id}",
        //        //ContentType = "text/html",
        //        ContentType = "object/json",
        //        StatusCode = 200
        //    };

        //    return contentResult;
        //}

        //public RedirectResult GetMovie(int id)
        //{
        //    var redirectResult = new RedirectResult("https://www.google.com/");

        //    return redirectResult;
        //}

        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMovie", "Movie", new { id });

        //    return redirectToActionResult;
        //}

        //[ActionName("GetMovie")]
        //[HttpGet]
        //public IActionResult GetMovieById(int id)
        //{
        //    if (id == 1)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie With Id: {id}", ContentType = "text/html", StatusCode = 200 };
        //        return Content($"Get Movie With Id: {id}", "text/html");
        //    }
        //    else if (id == 2)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie With Id: {id}", ContentType = "object/json", StatusCode = 200 };
        //        return Content($"Get Movie With Id: {id}", "object/json");
        //    }
        //    else if (id == 3)
        //    {
        //        //return new RedirectResult("https://www.google.com/");
        //        return Redirect("https://www.google.com/");
        //    }
        //    else
        //    {
        //        //return new RedirectToActionResult("AddMovie", "Movie", new { id });
        //        return RedirectToAction("AddMovie", "Movie", new { id });
        //    }
        //}

        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id: {id}";
        //}

        // Actions Parameter Binding
        // 1. Form
        // 2. Segment
        // 3. Query Params
        // 4. Files

        //public IActionResult GetMovie(int id)
        //{
        //    return Content($"Get Movie With Id: {id}", "text/html");
        //}

        public IActionResult GetMovie(Movie movie)
        {
            return Content($"Get Movie With Id: {movie.Id}, Name: {movie.Name}", "text/html");
        }
    }
}
