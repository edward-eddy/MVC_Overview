using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace MVC_Overview.Controllers
{
    // MVC Controller
    public class MovieController : Controller
    {
        // Actions : public non-static method
        public string GetMovie(int id)
        {
            return $"Get Movie With Id: {id}";
        }
        public string AddtMovie(int id)
        {
            return $"Add Movie With Id: {id}";
        }
    }



}
