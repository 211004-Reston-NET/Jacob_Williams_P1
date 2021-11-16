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
        private ILineItemsBL _lineItemsBL;
        private static Order _staticOrder = new Order();
        private ICustomerBL _customerBL;
        //private static List<LineItems> _shoppingCart = new List<LineItems>();
        private static List<LineItems> _checkOutCart = new List<LineItems>();

        public PlaceOrderController(IOrderBL p_orderBL, IStoreFrontBL p_storeFrontBL, Project_0_DatabaseContext p_context, ILineItemsBL p_lineItemsBL, ICustomerBL p_customerBL)
        {
            _context = p_context;
            _storeFrontBL = p_storeFrontBL;
            _orderBL = p_orderBL;
            _lineItemsBL = p_lineItemsBL;
            _customerBL = p_customerBL;
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
        public ActionResult Details(int p_lineItemId)
        {
            LineItems itemToAdd = _lineItemsBL.GetLineItemById(p_lineItemId);
            if (itemToAdd != null)
            {
                itemToAdd.LineItemQuantity = 1;
                _staticOrder.LineItems.Add(itemToAdd);
                decimal totalPrice = (decimal)_staticOrder.LineItems.Sum(item => item.Product.ProductPrice);
                if (totalPrice >= 0)
                {
                    ViewData.Add("TotalPrice", totalPrice);
                }
                else
                {
                    ViewData.Add("TotalPrice", 0);
                }
            }
            return View(nameof(Index));
        }

        public ActionResult ThanksForShopping()
        {
            return View();
        }

        public ActionResult CheckOut(int p_lineItemId) //figure this stuff out!!
        {
            LineItems itemFound = _lineItemsBL.GetLineItemById(p_lineItemId);
            _checkOutCart.Add(itemFound);
            return View(nameof(ThanksForShopping));
        }
        
        public ActionResult Cart(int p_lineItemId)
        {
            LineItems itemFound = _lineItemsBL.GetLineItemById(p_lineItemId);
            _checkOutCart.Add(itemFound);
            return View(_checkOutCart.Select(item => new LineItemVM(item))
                .ToList());
        }


        // GET: PlaceOrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlaceOrderController/Create



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Order _orderBeingPlaced = new Order();
                foreach (LineItems product in _checkOutCart)
                {
                    _orderBeingPlaced.LineItems.Add(product);
                }
                _orderBeingPlaced.CustomerId = SingletonVM.customer.CustomerId;
                _orderBeingPlaced.TotalPrice = (decimal)_checkOutCart.Sum(Item => Item.Product.ProductPrice);
                _orderBeingPlaced.StoreFrontId = _checkOutCart[0].StoreFrontId;
                _orderBeingPlaced.Address = _storeFrontBL.GetStoreFrontById(_orderBeingPlaced.StoreFrontId).StoreFrontAddress;
                Console.WriteLine(_orderBeingPlaced.CustomerId);
                Console.WriteLine(_orderBeingPlaced.TotalPrice);
                _orderBL.PlaceOrder(SingletonVM.customer, _orderBeingPlaced);
                return RedirectToAction("Index", "PlaceOrder");

            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception.Message);
                return View();
            }
            //if (ModelState.IsValid)
            //{
            //    _orderBL.PlaceOrder(new Customer(), new Order()
            //    {
            //        OrdersId = p_lineItemId.OrdersId,
            //        TotalPrice = placeOrderVM.TotalPrice,
            //        StoreFrontId = placeOrderVM.StoreFrontId,
            //        CustomerId = placeOrderVM.CustomerId,
            //        Address = placeOrderVM.Address

            //    });
            //    return RedirectToAction(nameof(Index));
            //}

            //LineItems lineItemToAdd = _lineItems.GetLineItemById(p_lineItemId);
            //_staticOrder.LineItems.Add(lineItemToAdd);
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
