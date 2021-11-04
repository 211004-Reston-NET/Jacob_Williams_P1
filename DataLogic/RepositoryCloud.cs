using System.Collections.Generic;
using Model = Models;
using DataLogic;
using Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataLogic
{


    public class RepositoryCloud : IRepository
    {
        private Project_0_DatabaseContext _context;
        public RepositoryCloud(Project_0_DatabaseContext p_context)
        {
            _context = p_context;
        }
        public Customer AddCustomer(Customer p_cust)
        {
            _context.Customers.Add
            (
                new Customer()
                {
                    Name = p_cust.Name,
                    Address = p_cust.Address,
                    Email = p_cust.Email,
                    PhoneNumber = p_cust.PhoneNumber,                   
                }
            );
            _context.SaveChanges();
            return p_cust;
        }

        public List<Customer> GetAllCustomer()
        {
            return _context.Customers.Select(cust => 
                new Customer()
                {
                    Name = cust.Name,
                    Address = cust.Address,
                    Email = cust.Email,
                    PhoneNumber = cust.PhoneNumber,
                    CustomerId = cust.CustomerId,
                }
            
            ).ToList();
        }

        public List<LineItems> GetAllLineItems(int p_storeId)
        {
            return _context.LineItems
            .Where(item => item.StoreFront.StoreFrontId == p_storeId)
            .Select(item =>
                new LineItems()
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

        public List<Product> GetAllProduct()
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
                .FirstOrDefault<Product>(prod => prod.ProductId == p_productId);
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
                .FirstOrDefault<Customer>(cust => cust.CustomerId == p_customer.CustomerId);
                customer.Orders.Add(new Order()
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

        public Order LineItemIventory(LineItems p_lineItemQuantity, LineItems p_lineItemId)
        {
            
            return null;
        }

        public List<LineItems> GetLineItems(int p_storeId)
        {
            return _context.LineItems
            .Where(item => item.StoreFront.StoreFrontId == p_storeId)
            .Select(Item => 
                new LineItems()
                {
                    Product = new Product(){ //??? Do I add it manually into lineitems? or have to go through DB? If things get weird here delete it out of LineItems in Models
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

        public List<Order> OrderHistory()
        {
            return _context.Orders.Select(prod => 
                new Order()
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
                .FirstOrDefault<LineItems>(dbItem => dbItem.LineItemId == p_lineItemId);
                repInv.LineItemQuantity = p_lineItemQuantity;
                _context.SaveChanges();
        }

        StoreFront IRepository.RepInventory(int p_lineItemId, int p_lineItemQuantity)
        {
            throw new System.NotImplementedException();
        }

        public LineItems GetLineItemById(int p_id)
        {
            LineItems lineItemIdFound = _context.LineItems.AsNoTracking().FirstOrDefault(rev => rev.LineItemId == p_id);
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
            LineItems invUpdated = new LineItems()
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
