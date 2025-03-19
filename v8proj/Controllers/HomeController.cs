using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Npgsql;

using v8proj.Web.Model; // Make sure you have the appropriate using statement for your model

namespace v8proj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Database connection check
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Пытаемся подключиться к базе
                    using (var cmd = new NpgsqlCommand("SELECT NOW();", connection)) // Простой запрос
                    {
                        var result = cmd.ExecuteScalar(); // Получаем результат
                        ViewBag.DbConnectionStatus = "Connection successful. Current time: " + result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.DbConnectionStatus = "Error connecting to database: " + ex.Message;
                }
            }

            // List of cars to be displayed in the view
             List<eUseControl> cars = new List<eUseControl>
            {
                new eUseControl { CartName = "Mercedes", CartDescription = "Good car", CartPrice = 10000, CartImage = "https://via.placeholder.com/400x300" },
                new eUseControl { CartName = "BMW", CartDescription = "Sporty and powerful", CartPrice = 12000, CartImage = "https://via.placeholder.com/400x300" },
                new eUseControl { CartName = "Audi", CartDescription = "Luxury and comfort", CartPrice = 15000, CartImage = "https://via.placeholder.com/400x300" }
            };

            // Pass both the connection status and the list of cars to the view
            ViewBag.Cars = cars; // Passing list of cars
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Avtorization()
        {
            return View();
        }

        public ActionResult Setings()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
    }
}
