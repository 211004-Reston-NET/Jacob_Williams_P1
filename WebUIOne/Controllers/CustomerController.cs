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
    public class CustomerController : Controller
    {

        private ICustomerBL _customerBL;
        public CustomerController(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }

        // GET: CustomerController
        public ActionResult Index()
        {

            ViewData.Add("CustomerName", SingletonVM.customer.Name);
            ViewData.Add("CustomerAddress", SingletonVM.customer.Address);
            return View(_customerBL.GetAllCustomer()
                        .Select(customer => new CustomerVM(customer))
                        .ToList()
                
            );
        }

        // GET: CustomerController/Details
        public ActionResult Details()
        {
            return View();
        }
        // GET: CustomerController/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(CustomerVM p_customerVM)
        {
            ViewBag.CustomerName = SingletonVM.customer.Name;
            ViewBag.CustomerAddress = SingletonVM.customer.Address;
            if (ModelState.IsValid)
            {
                SingletonVM.customer = _customerBL.GetCustomer(p_customerVM.Name, p_customerVM.Address);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerVM customerVM)
        {
            ViewData.Add("CustomerName", SingletonVM.customer.Name);
            ViewData.Add("CustomerAddress",  SingletonVM.customer.Address);
            if (ModelState.IsValid)
            {
                _customerBL.AddCustomer(new Customer()
                {
                    Name = customerVM.Name,
                    Address = customerVM.Address,
                    Email = customerVM.Email,
                    PhoneNumber = customerVM.PhoneNumber
                });
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit()
        {
            ViewBag.testName = SingletonVM.customer.Name;
            ViewBag.Address = SingletonVM.customer.Address;
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
