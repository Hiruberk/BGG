using BGGApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BGGApp.Controllers
{
    public class HomeController : Controller
    {
        private BGGDAL bGGDAL = new BGGDAL();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CollectionDisplay(string[] username)
        {
            List<CollectionRoot> collections = new List<CollectionRoot>();
            List<GameRoot> games = new List<GameRoot>();
            try
            {
                foreach (string name in username)
                {
                    collections.Add(bGGDAL.GetCollection(name.Trim()));
                }

            }catch(Exception e)
            {
                TempData["Error"] = e.ToString();
                return RedirectToAction("Index");
            }

            foreach(CollectionRoot c in collections)
            {
                foreach(Item i in c.items.item)
                {
                    if (!String.IsNullOrEmpty(i._attributes.objectid))
                    {
                        GameRoot game = new GameRoot();
                        game = bGGDAL.GetGame(i._attributes.objectid);
                        games.Add(game);
                    }

                }
            }

            if(games.Count > 0)
            {
                return View(games);
            }
            else
            {
                TempData["Error"] = "No games were found in your collection, please update your collection.";
                return RedirectToAction("Index");
            }


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
