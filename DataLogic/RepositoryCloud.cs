using System.Collections.Generic;
using Model = Models;
using DataLogic;
using Models;
using Entity = DataLogic.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataLogic
{


    public class RepositoryCloud : IRepository
    {
        private Entity.Project_0_DatabaseContext _context;
        public RepositoryCloud(Entity.Project_0_DatabaseContext p_context)
        {
            _context = p_context;
        }
        public Model.Customer AddCustomer(Model.Customer p_cust)
        {
            _context.Customers.Add
            (
                new Entity.Customer()
                {
                    CustomerName = p_cust.Name,
                    CustomerAddress = p_cust.Address,
                    CustomerEmail = p_cust.Email,
                    CustomerPhonenumber = p_cust.PhoneNumber,                   
                }
            );
            _context.SaveChanges();
            return p_cust;
        }

        public List<Model.Customer> GetAllCustomer()
        {
            return _context.Customers.Select(cust => 
                new Model.Customer()
                {
                    Name = cust.CustomerName,
                    Address = cust.CustomerAddress,
                    Email = cust.CustomerEmail,
                    PhoneNumber = cust.CustomerPhonenumber,
                    CustomerId = cust.CustomerId,
                }
            
            ).ToList();
        }

        public List<Model.LineItems> GetAllLineItems(int p_storeId)
        {
            return _context.LineItems
            .Where(item => item.StoreFront.StoreFrontId == p_storeId)
            .Select(item =>
                new Models.LineItems()
                {
                    ProductId = item.ProductId,
                    LineItemQuantity = item.LineItemQuantity,
                    LineItemId = item.LineItemId,
                    StoreFrontId = item.StoreFrontId
                }
                ).ToList();
        }

        public List<LineItems> GetAllLineItems()
        {
            throw new System.NotImplementedException();
            //???
        }

        public List<Model.Product> GetAllProduct()
        {
            return _context.Products.Select(prod => new Models.Product()
            {
                ProductId = prod.ProductId,
                ProductName = prod.ProductName,
                ProductDescription = prod.ProductDescription,
                ProductPrice = (int)prod.ProductPrice
            }
            ).ToList();
        }

        public Order GetOrderByProductAndStoreFrontId(int p_productId, int p_storeId)
        {
            throw new System.NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductByProductId(int p_productId)
        {
            var result = _context.Products
                .FirstOrDefault<Entity.Product>(prod => prod.ProductId == p_productId);
            return new Models.Product()
            {
                ProductName = result.ProductName,
                ProductPrice = (int)result.ProductPrice,
                ProductDescription = result.ProductDescription,
                ProductId = result.ProductId
            };
        }

        public List<Model.StoreFront> GetStoreFrontList()
        {
            return _context.StoreFronts.Select(store => new Models.StoreFront()
            {
                StoreFrontName = store.StoreFrontName,
                StoreFrontAddress = store.StoreFrontAddress,
                StoreFrontId = store.StoreFrontId,
            }
            ).ToList();
        }

        public Models.Order PlaceOrder(Models.Customer p_customer, Models.Order p_order)
        {
            var customer = _context.Customers
                .FirstOrDefault<Entity.Customer>(cust => cust.CustomerId == p_customer.CustomerId);
                customer.Orders.Add(new Entity.Order()
                {
                    OrdersId = p_order.OrdersId,
                    TotalPrice = p_order.TotalPrice,
                    StoreFrontId = p_order.StoreFrontId,
                    CustomerId = p_order.CustomerId,
                    Address = p_order.Address
                });
                _context.SaveChanges();
                return p_order;
        }

        public Models.Order LineItemIventory(Models.LineItems p_lineItemQuantity, Models.LineItems p_lineItemId)
        {
            
            return null;
        }

        public List<Models.LineItems> GetLineItems(int p_storeId)
        {
            return _context.LineItems
            .Where(item => item.StoreFront.StoreFrontId == p_storeId)
            .Select(Item => 
                new Models.LineItems()
                {
                    Product = new Models.Product(){ //??? Do I add it manually into lineitems? or have to go through DB? If things get weird here delete it out of LineItems in Models
                        ProductName = Item.Product.ProductName,
                        ProductPrice = (int)Item.Product.ProductPrice,
                        ProductDescription = Item.Product.ProductDescription,
                        ProductId = Item.Product.ProductId,
                    },
                    LineItemQuantity = Item.LineItemQuantity,
                    LineItemId = Item.LineItemId,
                    StoreFrontId = Item.StoreFrontId
                }
            ).ToList();   
        }

        public Order PlaceOrder(int p_productId, int p_storeId)
        {
            throw new System.NotImplementedException();
        }

        public Order PlaceOrder()
        {
            throw new System.NotImplementedException();
        }

        public List<Order> OrderHistoryBL()
        {
            throw new System.NotImplementedException();
        }

        public List<Model.Order> OrderHistory()
        {
            return _context.Orders.Select(prod => 
                new Model.Order()
                {
                    OrdersId = prod.OrdersId,
                    CustomerId = prod.CustomerId,
                    StoreFrontId = prod.StoreFrontId,
                    TotalPrice = prod.TotalPrice,
                    Address = prod.Address,
                }
            
            ).ToList();
        }

        public void RepInventory(int p_lineItemId, int p_lineItemQuantity)
        {
            var repInv = _context.LineItems
                .FirstOrDefault<Entity.LineItem>(dbItem => dbItem.LineItemId == p_lineItemId);
                repInv.LineItemQuantity = p_lineItemQuantity;
                _context.SaveChanges();
        }

        StoreFront IRepository.RepInventory(int p_lineItemId, int p_lineItemQuantity)
        {
            throw new System.NotImplementedException();
        }

        public LineItems GetLineItemById(int p_id)
        {
            Entity.LineItem lineItemIdFound = _context.LineItems.AsNoTracking().FirstOrDefault(rev => rev.LineItemId == p_id);
            return new Model.LineItems()
            {
                LineItemId = lineItemIdFound.LineItemId,
                LineItemQuantity = lineItemIdFound.LineItemQuantity,
                StoreFrontId = lineItemIdFound.StoreFrontId,
                ProductId = lineItemIdFound.ProductId
            };
        }

        public Models.LineItems UpdateInventory(Models.LineItems p_upd)
        {
            Entity.LineItem invUpdated = new Entity.LineItem()
            {
                LineItemId = p_upd.LineItemId,
                LineItemQuantity = p_upd.LineItemQuantity,
                StoreFrontId = p_upd.StoreFrontId,
                ProductId = p_upd.ProductId
            };
            _context.LineItems.Update(invUpdated);
            _context.SaveChanges();

            return p_upd;
        }
    }
}
