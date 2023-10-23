using Microsoft.AspNetCore.Mvc;

namespace PortafolioI.Controllers;

public class PortafolioController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpGet("projects")]
    public IActionResult Projects()
    {
        string texto = "Lorem ipsum dolor sit amet consectetur adipisicing elit. At possimus vero facere obcaecati. Placeat nemo ducimus autem sint temporibus nostrum! Corporis accusantium exercitationem est voluptate odit!Eum abdelectus nulla";
        string titulo = "Proyecto";
        ViewBag.Texto = texto;
        ViewBag.Titulo = titulo;
        return View("projects");
    }
    [HttpGet("contact")]
    public ViewResult Contact()
    {

        return View("contact");
    }

}