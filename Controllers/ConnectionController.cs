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

    [HttpPost]
    public IActionResult LoginPostgres(LoginPostgresViewModel model)
    {
        string conn = $"User ID={model.Username};Password={model.Password};Host={model.Hostname};Database={model.DBname};Port={model.Port}";
        // var connection = new NpgsqlConnection(conn);
        ViewData["connectionString"] = conn;
        return View(model);
    }

    [HttpPost]
    public IActionResult LoginSqlserver(LoginSqlserverViewModel model)
    {
        return View(model);
    }
}
