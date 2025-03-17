using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace v8proj.Controllers
{
    public class AdminController : HomeController
    {
        // Панель управления
        public ActionResult Dashboard()
        {
            return View();
        }

        // Управление пользователями
        public ActionResult Users()
        {
            return View();
        }

        // Управление концептами
        public ActionResult Concepts()
        {
            return View();
        }

        // Настройки сайта
        public ActionResult Settings()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveSettings(string siteName, int maxUploadSize, string theme)
        {
            // В реальном проекте здесь можно сохранить настройки в базе данных или в конфигурации

            ViewBag.Message = "Настройки сохранены!"; // Отобразим сообщение пользователю

            return View("Settings");
        }
    }
}