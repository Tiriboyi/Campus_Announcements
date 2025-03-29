using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Campus_Announcements.Models;
using Campus_Announcements.Services;

namespace Campus_Announcements.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IAnnouncementService _announcementService;

    public HomeController(ILogger<HomeController> logger, IAnnouncementService announcementService)
    {
        _logger = logger;
        _announcementService = announcementService;
    }

    public IActionResult Index()
    {
        var viewModel = new HomeViewModel
        {
            Announcements = _announcementService.GetAnnouncements()
        };
        return View(viewModel);
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
