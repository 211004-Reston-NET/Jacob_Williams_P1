// using System;

// namespace UserInterface
// {
//     public class StoreFront : IMenu
//     {
//         public void Menu()
//         {
//             //Make sure to add a case into Program.cs, MainMenu and IMenu for each class
//             Console.WriteLine("    ----- Store Front Menu -----");
//             Console.WriteLine("[1] - Store Locations");
//             Console.WriteLine("[2] - Return To The Main Menu");
//             Console.WriteLine("[3] - Exit");
//         }

//         public MenuType UserChoice()
//         {
//             string userChoice = Console.ReadLine();
            
//             switch(userChoice)
//             {
//                 //For this we should create 2 different json files for our 2 differen locations
//                 //ask Stephen for help on this?
//                 //case 1 is for choosing from one of the two locations
//                 //this references the Locations.cs 
//                 case "1":
//                     //Console.WriteLine("Choose A Location Near You"); // these aren't needed or you'll need to hit enter twice
//                     //Console.ReadLine();
//                     return MenuType.Locations; //this one should be location
//                 case "2":
//                     return MenuType.MainMenu;
//                 case "3":
//                     return MenuType.Exit;
//                 default:
//                     Console.WriteLine("Please Select From The List Of Options Provided");
//                     Console.WriteLine("Please Press Enter To Continue");
//                     Console.ReadLine();
//                     return MenuType.StoreFront;
//             } 
//         }
//     }
// }