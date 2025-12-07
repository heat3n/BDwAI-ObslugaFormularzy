using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Formularz.Controllers
{
    public class RejestracjaController : Controller
    {
        [HttpGet]
        public IActionResult Formularz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formularz(RejestracjaModel model)
        {
            
            if (ModelState.IsValid)
            {
                return View("Sukces", model);
            }

            return View(model);
        }
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RejestracjaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RejestracjaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RejestracjaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RejestracjaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
