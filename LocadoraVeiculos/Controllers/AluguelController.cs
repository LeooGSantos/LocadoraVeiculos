using Microsoft.AspNetCore.Mvc;
using LocadoraVeiculos.Models;

namespace LocadoraVeiculos.Controllers
{
    public class VeiculoController : Controller
    {
        // GET: /Veiculo/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Veiculo/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: /Veiculo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Veiculo/Create
        [HttpPost]
        public IActionResult Create(Veiculo veiculo)
        {
            return RedirectToAction(nameof(Index));
        }

        // GET: /Veiculo/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: /Veiculo/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Veiculo veiculo)
        {
            return RedirectToAction(nameof(Index));
        }

        // GET: /Veiculo/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: /Veiculo/Delete/5
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
