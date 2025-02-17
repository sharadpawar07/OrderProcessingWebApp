using OrderProcessingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderProcessingSystem.Controllers
{
    public class OrderController : Controller
    {

        OrderProcessingDBEntities db = new OrderProcessingDBEntities();

        public ActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]

        public ActionResult CreateOrder(Order order) 
        {
            if (ModelState.IsValid)
            {
                // Apply discount logic
                if (order.CustomerType == "Loyal" && order.OrderAmount >= 100)
                {
                    order.DiscountAmount = order.OrderAmount * 0.10m;
                }
                else
                {
                    order.DiscountAmount = 0;
                }

                order.FinalTotal = order.OrderAmount - order.DiscountAmount;

                // Save to database
                db.Orders.Add(order);
                db.SaveChanges();

                TempData["OrderPlaced"] = true;

                return RedirectToAction("OrderSummary", new { id = order.OrderId });
            }
            return View(order);
        }
        public ActionResult OrderSummary(int id)
        {
            var order = db.Orders.Find(id);
            return View(order);
        }

      

    }
    }
