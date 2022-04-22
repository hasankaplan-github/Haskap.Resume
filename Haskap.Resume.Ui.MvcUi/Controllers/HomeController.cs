using Haskap.Resume.Application.UseCaseServices.Contracts;
using Haskap.Resume.Application.UseCaseServices.Dtos;
using Haskap.Resume.Ui.MvcUi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Haskap.Resume.Ui.MvcUi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IContactService _contactService;

    public HomeController(ILogger<HomeController> logger, IContactService contactService)
    {
        _logger = logger;
        _contactService=contactService;
    }

    public IActionResult Index()
    {
        return View();
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

    [HttpPost]
    public async Task<IActionResult> SendMessage(SendMessageInputDto sendMessageInputDto)
    {
        await _contactService.SendMessage(sendMessageInputDto);
        return RedirectToAction(nameof(Index));
    }
}
