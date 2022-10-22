using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dbms_cyrille.Models;

namespace dbms_cyrille.Controllers;

public class ConnectionController : Controller
{
    private readonly ILogger<ConnectionController> _logger;

    public ConnectionController(ILogger<ConnectionController> logger)
    {
        _logger = logger;
    }

    public IActionResult LoginPostgres()
    {
        return View();
    }

    public IActionResult LoginSqlserver()
    {
        return View();
    }
}
