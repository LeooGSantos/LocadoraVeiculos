using Microsoft.AspNetCore.Mvc;
using LocadoraVeiculos.Models;

namespace LocadoraVeiculos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: /Cliente/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Cliente/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: /Cliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Cliente/Create
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            return RedirectToAction(nameof(Index));
        }

        // GET: /Cliente/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: /Cliente/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Cliente cliente)
        {
            return RedirectToAction(nameof(Index));
        }

        // GET: /Cliente/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: /Cliente/Delete/5
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
