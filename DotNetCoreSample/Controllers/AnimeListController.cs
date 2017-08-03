using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using DotNetCoreSample.Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreSample.Controllers
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
            this.AnimeService = animeService;
        }
        
    }
}
