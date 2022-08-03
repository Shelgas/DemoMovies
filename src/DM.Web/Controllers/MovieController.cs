using Microsoft.AspNetCore.Mvc;

namespace DM.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IRepositoryWrapper _repository;

        public MovieController(IRepositoryWrapper repository)
        {
            this._repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _repository.Movie.GetAllMoviesAsync();
            return View(allMovies);
        }
    }
}
