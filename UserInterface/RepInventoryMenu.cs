// using System;
// using System.Collections.Generic;
// using BusinessLogic;
// using Models;

// namespace UserInterface
// {
//     public class RepInventoryMenu : IMenu
//     {
//         private LineItemsBL _lineItems;
//         public RepInventoryMenu(LineItemsBL p_lineItemsBL)
//         {
//             _lineItems = p_lineItemsBL;
//         }
//         public void Menu()
//         {
//             Console.WriteLine($"LineItemId - {SingletonCustomer.order.LineItems}");
//             Console.WriteLine($"LineItemQuantity - {SingletonCustomer.order.LineItems}");
//         }

//         public MenuType UserChoice()
//         {
//             List<LineItems> listOfLineItems = _lineItems.GetAllLineItem(SingletonCustomer.order.StoreFrontId);
//             foreach(LineItems prod in listOfLineItems)
//             {
//                 Console.WriteLine("Line Item ID:");
//                 Console.WriteLine("===============");
//                 Console.WriteLine(prod.LineItemId);
//                 Console.WriteLine("===============");
//                 Console.WriteLine("");
//                 Console.WriteLine("Line Item Quantity:");
//                 Console.WriteLine("===============");
//                 Console.WriteLine(prod.LineItemQuantity);
//                 Console.WriteLine("===============");
//                 Console.WriteLine("");
//             }
            
            
//             string userChoice = Console.ReadLine();
//             {
//                 switch (userChoice)
//                 {
//                     case "1":
//                         Console.WriteLine("Please Enter The Line Item Id For The Item You Wish To Replenish");
//                         Console.ReadLine();
//                         int _inputId = int.Parse(Console.ReadLine());
//                         foreach(LineItems prod in listOfLineItems)
//                         {
//                             if(_inputId == prod.LineItemId)
//                             {
//                                 Console.WriteLine($"How Many Of LineItem {_inputId} Would You Like?");     
//                                 int _inputQuantity = int.Parse(Console.ReadLine());
//                                 if (_inputQuantity > prod.LineItemQuantity)
//                                 {
//                                     Console.WriteLine("Please Enter Appropriate Amount");
//                                 }
//                                 else 
//                                 {
//                                     prod.LineItemQuantity += _inputQuantity;
//                                     SingletonCustomer.order.LineItems.Add(prod);
//                                     Console.WriteLine("");
//                                     Console.WriteLine($"{_inputQuantity} Of LineItemId {_inputId} Have Been Replenished");
//                                     Console.WriteLine("=========================");
//                                     Console.WriteLine("=========================");
//                                 }                       
//                             }
//                         }
//                         Console.WriteLine("");
//                         Console.WriteLine("How Would You Like To Proceed?");
//                         Console.WriteLine("==============================");
//                         Console.WriteLine("[1] - Keep Replenishing Inventory");
//                         Console.WriteLine("[2] - Return To Main Menu");
//                         Console.WriteLine("[3] - Exit");

//                         userChoice = Console.ReadLine();
//                         switch (userChoice)
//                         {
//                             case "1":
//                                 return MenuType.RepInventoryMenu;
//                             case "2":
//                                 return MenuType.MainMenu;
//                             case "3":
//                                 return MenuType.Exit;
//                         }
//                         return MenuType.RepInventoryMenu;
//                     default:
//                         Console.WriteLine("Please Select From The Options Provided");
//                         Console.WriteLine("Please Press Enter To Continue");
//                         Console.ReadLine();
//                         return MenuType.RepInventoryMenu;
//                 }
//             }
//         }
        
//         // public void RepInventory(int p_lineItemId, int p_lineItemQuantity)
//         // {
//         //     var repInv = _context.LineItems
//         //         .FirstOrDefault<Entity.LineItem>(dbItem => dbItem.LineItemId == p_lineItemId);
//         //         repInv.LineItemQuantity = p_lineItemQuantity;
//         //         _context.SaveChanges();
//         // }
//     }
// }