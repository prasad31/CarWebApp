using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test1234.Models;
using ServiceStack.Redis;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;
using Microsoft.EntityFrameworkCore;

namespace test1234.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            // return View();
            System.Environment.Exit(12);
            return View();
        }

        public IActionResult Dummy()
        {
           
                var host = "redis-server"; 
                var port = Convert.ToInt32("6379");
                RedisEndpoint redisEndpoint = new RedisEndpoint(host, port);

                using (var client = new RedisClient(redisEndpoint))
                {
                    ViewBag.Visit = client.Increment("Website_Counter", 1);
                   // session["pagehit"] = ViewBag.Visit;
                   // ViewBag.tempvar = client.IncrBy("testvar", 5);
                }

                return View();
            
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
