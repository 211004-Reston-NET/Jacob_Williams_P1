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
    public class OrderHistoryController : Controller
    {
        private IOrderBL _orderBL;
        private IOrderHistoryBL _orderHistoryBL;
        private static List<Order> __orderHistoryList = new List<Order>();
        public OrderHistoryController(IOrderBL p_orderBL, IOrderHistoryBL p_orderHistoryBL)
        {
            _orderBL = p_orderBL;
            _orderHistoryBL = p_orderHistoryBL;
        }
        
        // GET: OrderHistoryController
        public ActionResult Index()
        {
            return View(_orderHistoryBL.OrderHistory()
                .Select(order => new OrderHistoryVM(order))
                .ToList()
                );
        }

        // GET: OrderHistoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderHistoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderHistoryController/Create
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

        // GET: OrderHistoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderHistoryController/Edit/5
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

        // GET: OrderHistoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderHistoryController/Delete/5
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
