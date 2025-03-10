using System;
using System.Web.Mvc;

public class ErrorController : Controller
{
    public ActionResult Index(Exception exception)
    {
        return View("Error");
    }
} 