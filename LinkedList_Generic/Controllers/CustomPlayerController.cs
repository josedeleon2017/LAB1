using LinkedList_Generic.Models;
using CustomGenerics.Structures;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LinkedList_Generic.Double_LinkedList.Helpers;

namespace LinkedList_Generic.Controllers
{
    public class CustomPlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            var player1 = new CustomPlayerModel { Name = "José", LastName = "De Leon", Position = "MD", Club = "CHI", Salary = 30000, };
            var player2 = new CustomPlayerModel { Name = "Javier", LastName = "Morales", Position = "MD", Club = "CHI", Salary = 30000, };

            Custom_Storage.Instance.playerList2.Agregar(player1);
            Custom_Storage.Instance.playerList2.Agregar(player2);


            return View(Custom_Storage.Instance.playerList2);
        }

        // GET: Player/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var player = new CustomPlayerModel
                {
                    Name = collection["Name"],
                    LastName = collection["LastName"],
                    Club = collection["Club"],
                    Position = collection["Position"],
                    Salary = int.Parse(collection["Salary"]),
                };

                Custom_Storage.Instance.playerList2.Agregar(player);          
                return RedirectToAction("Index");                
               
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Edit/5
        public ActionResult Edit(string id)
        {
            var nombre = id;
            return View();
        }

        // POST: Player/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var nombre = id;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Player/Delete/5
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
