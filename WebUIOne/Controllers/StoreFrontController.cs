using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUIOne.Models;

namespace WebUIOne.Controllers
{
    public class StoreFrontController : Controller
    {
        private IStoreFrontBL _storeBL;
        public StoreFrontController(IStoreFrontBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        // GET: StoreFrontController
        public ActionResult Index()
        {
            //gets our list of storefronts from the BL
            //we then converted that model storefront into storeVM using select method
            //finally we changed it to a List with ToList()
            return View(_storeBL.GetStoreFrontList()
                        .Select(store => new StoreFrontVM(store))
                        .ToList()
            );
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StoreFrontVM storeVM)    //This Will be used for Add Customer!! Not so much for this, we don't have
        {          
            //This If statement will check if the current model that is being passed through is valid
            //If not, the asp-validation-for elemtns will appear and autofill in the proper feedback
            //for the user to correct themselves
            //if (ModelState.IsValid)
            //{
                //_storeBL.AddStoreFront(new StoreFront()
                //{
                    //StoreFrontName = storeVM.StoreFrontName,
                    //StoreFrontAddress = storeVM.StoreFrontAddress

                //});
                //return RedirectToAction(nameof(Index));
            //}
            //Will return back to the create view if the user didn't specify the right input
            return View();
        }

        // GET: StoreFrontController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreFrontController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreFrontController/Edit/5
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

        // GET: StoreFrontController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreFrontController/Delete/5
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
