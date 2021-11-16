using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUIOne.Models;

namespace WebUIOne.Controllers
{
    public class ReplenishInventoryController : Controller
    {
        // GET: ReplenishInventoryController
        private IChangeInvBL _changeInvBL;
        public int p_howMuchAdded;
        public ReplenishInventoryController(IChangeInvBL p_changeInvBL)
        {
            _changeInvBL = p_changeInvBL;
        }
        
        public ActionResult Index(ReplenishInventoryVM p_replenishInventoryVM)
        {
            ViewData.Add("LineItemId", p_replenishInventoryVM.LineItemId);
            ViewData.Add("LineItemQuantity", p_replenishInventoryVM.LineItemQuantity);
            return View();
        }

            //return View(_changeInvBL.GetLineItemById(p_replenishInventoryVM.LineItemId)
                        //.Select(item => new ReplenishInventoryVM(item))                         <---why don't you work?...
                        //.ToList()

        // GET: ReplenishInventoryController/Details/5
        public ActionResult Details(int p_id)
        {
            if (ModelState.IsValid)
            {
                _changeInvBL.GetLineItemById(p_id);
                return RedirectToAction(nameof(Index));
            }
            
            return View();
        }

        // GET: ReplenishInventoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReplenishInventoryController/Create
        [HttpPost]
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

        // GET: ReplenishInventoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReplenishInventoryController/Edit/5
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

        // GET: ReplenishInventoryController/Delete/5
        public ActionResult Delete(int id)
        {
            //ViewData.Add("LineItemId", _changeInvBL.GetLineItemById(id));
            //ViewData.Add("LineItemQuantity", p_howMuchAdded);
            return View(new ReplenishInventoryVM(_changeInvBL.GetLineItemById(id)));
        }

        // POST: ReplenishInventoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ReplenishInventoryVM replenishInventoryVM)
        {
                //ViewData.Add("LineItemId", toBeUpdated;
                //ViewData.Add("LineItemQuantity", _changeInvBL.GetLineItemById(replenishInventoryVM.LineItemQuantity));
            //try
            //{
                LineItems toBeUpdated = _changeInvBL.GetLineItemById(replenishInventoryVM.LineItemId);
                _changeInvBL.UpdateInventory(toBeUpdated, replenishInventoryVM.LineItemQuantity);
                ViewData.Add("LineItemId", toBeUpdated);
                ViewData.Add("LineItemQuantity", replenishInventoryVM.LineItemQuantity);
                return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
                //return View();
            //}
        }
    }
}
