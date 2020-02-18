using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LinkedList_Generic.Models;
using LinkedList_Generic.Double_LinkedList.Helpers;

namespace LinkedList_Generic.Controllers
{
    public class StandarPlayerController : Controller
    {


        // GET: StandarPlayer
        public ActionResult Index()
        {
            var player1 = new StandarPlayerModel { Name = "José", LastName = "De Leon", Position = "MD", Club = "CHI", Salary = 30000, };
            var player2 = new StandarPlayerModel { Name = "Javier", LastName = "Morales", Position = "MD", Club = "CHI", Salary = 30000, };
            player1.Save();
            player2.Save();

            return View(Storage.Instance.playerList);
        }

        // GET: StandarPlayer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StandarPlayer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StandarPlayer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var player = new StandarPlayerModel{
                    Name = collection["Name"],
                    LastName = collection["LastName"],
                    Club= collection["Club"],
                    Position= collection["Position"],
                    Salary = int.Parse(collection["Salary"]),
                };

                if (player.Save())
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(player);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: StandarPlayer/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: StandarPlayer/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                var player = new StandarPlayerModel
                {
                    Name = collection["Name"],
                    LastName = collection["LastName"],
                    Club = collection["Club"],
                    Position = collection["Position"],
                    Salary = int.Parse(collection["Salary"]),
                };
                player.Save();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StandarPlayer/Delete/5
        public ActionResult Delete(string id)
        {
            Predicate<StandarPlayerModel> buscador = (StandarPlayerModel player) => { return player.Name == id; };
            Storage.Instance.playerList.Find(buscador);
            return RedirectToAction("Index");
        }

        // POST: StandarPlayer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
