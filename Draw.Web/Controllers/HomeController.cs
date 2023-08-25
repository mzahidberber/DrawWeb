using Draw.Core.Business;
using Draw.Web.Mapper;
using Draw.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Draw.Web.Controllers;

public class HomeController : Controller
{
    
    private IMainTitleService _mainTitleService;
    
    private IEnumerable<MainTitle> _maintTitles;
    

		public HomeController(IMainTitleService mainTitleService)
		{
			_mainTitleService = mainTitleService;
			var mainTitles = _mainTitleService.GetAllWithBaseTitleAsync().Result;
			_maintTitles = WebObjectMapper.Mapper.Map<IEnumerable<MainTitle>>(mainTitles.data.ToList());

		}

    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
    public IActionResult Index()
    {
        return View(new TitleListViewModel { MainTitles = _maintTitles.Where(x => x.IndexId == 0).ToList(), url = "home" });
		}
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
    public IActionResult DrawCAD()
    {
        return View(new TitleListViewModel { MainTitles = _maintTitles.Where(x => x.IndexId == 1).ToList(), url = "cad" }); ;
    }
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
    public IActionResult DrawApi()
    {
        return View(new TitleListViewModel { MainTitles = _maintTitles.Where(x => x.IndexId == 2).ToList(), url = ":5000" });
		}
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
    public IActionResult DrawGeo()
    {
        return View(new TitleListViewModel { MainTitles = _maintTitles.Where(x => x.IndexId == 3).ToList(), url = ":5001/geo" });
		}
    [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any, NoStore = false)]
    public IActionResult DrawAuth()
    {
        return View(new TitleListViewModel { MainTitles = _maintTitles.Where(x => x.IndexId == 4).ToList(), url = ":5002" });
		}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}