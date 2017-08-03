using DotNetCoreSample.Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreSample.Presentation.Controllers
{
    public class AnimeListController : Controller
    {

        private IAnimeService AnimeService { get; set; }

        public IActionResult Index()
        {
            ViewData["CaptionSample"] = AnimeService.CaptionSample();
            return View();
        }

        // コンストラクタインジェクション例。
        public AnimeListController(IAnimeService animeService)
        {
            AnimeService = animeService;
        }
        
    }
}
