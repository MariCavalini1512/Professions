using Microsoft.AspNetCore.Mvc;
using Professions.Models;

namespace Professions.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            List<Genre> genres = new List<Genre>()

            {
            new Genre
                {
                    Id = 1,
                    Name = "Professor"
                },
            new Genre

                {
                    Id = 2,
                    Name = "Fisioterapeuta"
                },

            new Genre

                {
                    Id = 3,
                    Name = "Engenheiro"
                }
            };
            
            
            return View(genres);
        }
    }
}
