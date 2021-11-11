using BusinessLogic;
using DataLogic;
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
    public class PlaceOrderController : Controller
    {
        private IStoreFrontBL _storeFrontBL;
        private IOrderBL _orderBL;
        private Project_0_DatabaseContext _context;
        public PlaceOrderController(IOrderBL p_orderBL, IStoreFrontBL p_storeFrontBL, Project_0_DatabaseContext p_context)
        {
            _context = p_context;
            _storeFrontBL = p_storeFrontBL;
            _orderBL = p_orderBL;
        }

        //private ILineItemsBL _lineItemBL;
        //public PlaceOrderController(ILineItemsBL p_lineItemsBL)
        //{
            //_lineItemBL = p_lineItemsBL;
        //}
        
        // GET: PlaceOrderController
        public ActionResult Index()
        {
            return View(_storeFrontBL.GetStoreFrontList()
                .Select(store => new StoreFrontVM(store))
                .ToList()
                );
        }

        //GET: list of Line Items per store
        //public ActionResult Index1(PlaceOrderVM p_placeOrderVM)
        //{
           //if (ModelState.IsValid)
           //{
                //_lineItemBL.GetAllLineItem(p_placeOrderVM.StoreFrontId);
                //return RedirectToAction(nameof(Index));
           //}
            //return View();
        //}

        // GET: PlaceOrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlaceOrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlaceOrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlaceOrderVM placeOrderVM)
        {
            if (ModelState.IsValid)
            {
                _orderBL.PlaceOrder(new Customer(), new Order()
                {
                    OrdersId = placeOrderVM.OrdersId,
                    TotalPrice = placeOrderVM.TotalPrice,
                    StoreFrontId = placeOrderVM.StoreFrontId,
                    CustomerId = placeOrderVM.CustomerId,
                    Address = placeOrderVM.Address

                });
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: PlaceOrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlaceOrderController/Edit/5
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

        // GET: PlaceOrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlaceOrderController/Delete/5
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
