using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DSTeachers.Models;
using DSTeachers.Data;
using DSTeachers.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DSTeachers.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new() {
            Generos = [.. _context.Generos],
            Professores = [.. _context.Professores]
        };
        return View(home);
    }

    public IActionResult Details(int id)
    {
        Professor professor = _context.Professores
            .AsNoTracking()
            .Include(p => p.AudioGenero)
            .FirstOrDefault(p => p.Id == id);            
        return View(professor);
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
