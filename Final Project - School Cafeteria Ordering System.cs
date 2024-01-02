/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 02/01/2024
 * Time: 10:38 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
namespace sampkaloy
{
class Program
    {
        private static int SelectedIndex;
        private static string[] Options = {"Customer","Admin"};
        private static int origRow = 0;
        private static int origCol = 0;
        private static string Username;
        private static string Password;
        
        private static string adminUsername = "y";
        private static string adminPassword = "p";
        
      
        
        private static List<Tuple<string, int>> Stocks = new List<Tuple<string, int>>
        {
            new Tuple<string, int>("Rice",0),
            new Tuple<string, int>("Adobo",0),
            new Tuple<string, int>("Menudo",0),   
            new Tuple<string, int>("Chicken",0), 
            new Tuple<string, int>("Mami",0),   
            new Tuple<string, int>("Palabok",0),             
            new Tuple<string, int>("Lugaw",0),
            new Tuple<string, int>("Spaghetti",0),
            new Tuple<string, int>("Hotdog Sandwich",0),
            new Tuple<string, int>("Burger",0),
            new Tuple<string, int>("Kwek-Kwek",0),
            new Tuple<string, int>("Siomai",0),
            new Tuple<string, int>("Cheese Stick",0),
            new Tuple<string, int>("Fries",0),
            new Tuple<string, int>("Tokwa",0),
            
            
        };
        private static Dictionary<string, int> Sales = new Dictionary<string, int>();
        
        public static void Main()

        {
            Console.SetWindowSize(Console.WindowWidth,Console.WindowHeight);
            Console.SetBufferSize(Console.WindowWidth,Console.WindowHeight);
            Console.CursorVisible = true;
            int choice = RunMenu();
            switch (choice)
            {
                case 0:
                    DisplayItems();
                    break;
                    
                case 1:
                    RunAuthentication();
                    break;
            }
    

            Console.ReadKey(true);

        }
        
        public static void WriteAt(string s, int x, int y)
        {
        try
            {
            Console.SetCursorPosition(origCol+x, origRow+y);
            Console.Write(s);
            }
        catch (ArgumentOutOfRangeException e)
            {
            Console.Clear();
            Console.WriteLine(e.Message);
            }
        }

        
        public static void DisplayText()
        {
             Console.CursorVisible = false;
            
            string header = "   #####                                                       #######                                             ";
            string header1 = " #     #   ##   ###### ###### ##### ###### #####  #   ##      #     # #####  #####  ###### #####  # #    #  ####  ";
			string header2 = " #        #  #  #      #        #   #      #    # #  #  #     #     # #    # #    # #      #    # # ##   # #    # ";
			string header3 = " #       #    # #####  #####    #   #####  #    # # #    #    #     # #    # #    # #####  #    # # # #  # #      ";
  			string header4 = " #       ###### #      #        #   #      #####  # ######    #     # #####  #    # #      #####  # #  # # #  ### ";
 			string header5 = " #     # #    # #      #        #   #      #   #  # #    #    #     # #   #  #    # #      #   #  # #   ## #    # ";
 			string header6 = "  #####  #    # #      ######   #   ###### #    # # #    #    ####### #    # #####  ###### #    # # #    #  ####  ";
 			string header7 = "                                                                                                                  ";
 			string header8 = "                                      #####                                                                       ";
  			string header9 = "                                      #       #   #  ####  ##### ###### #    #                                     ";
  			string header10 = "                                     #        # #  #        #   #      ##  ##                                     ";
  			string header11 = "                                      #####    #    ####    #   #####  # ## #                                     ";
  			string header12 = "                                           #   #        #   #   #      #    #                                     ";
  			string header13 = "                                     #     #   #   #    #   #   #      #    #                                     ";
 			string header14 = "                                     #     #   #   #    #   #   #      #    #                                     ";
            string header15 = "                                      #####    #    ####    #   ###### #    #                                     ";	
            	
            	
            
            WriteAt(header,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 13);
            WriteAt(header1,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 12);
            WriteAt(header2,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 11);
            WriteAt(header3,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 10);
            WriteAt(header4,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 9);
            WriteAt(header5,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 8);
            WriteAt(header6,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 7);
            WriteAt(header7,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 6);
            WriteAt(header8,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 5);
            WriteAt(header9,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 4);
            WriteAt(header10,Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 3);
            WriteAt(header11, Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 2);
            WriteAt(header12, Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 1);
            WriteAt(header13, Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 - 0);
            WriteAt(header14, Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 + 1);
            WriteAt(header15, Console.WindowWidth/2 - header4.Length/2, Console.WindowHeight/2 + 2);
            
            

            
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                
                if (SelectedIndex == i){
                    
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }else{
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }                
                WriteAt("   "+currentOption+"   ", Console.WindowWidth/2 - (currentOption.Length/2 + 2), (Console.WindowHeight/2 + 8) + (i*3));
            }
            Console.ResetColor();
            
        }
        
          public static int RunMenu()
        {
        Console.CursorVisible = false;
        ConsoleKey keyPressed;
                do
                {
                    
                    Console.Clear();
                    DisplayText();
                    
                    
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    keyPressed = keyInfo.Key;
                    
                    if (keyPressed == ConsoleKey.DownArrow)
                    {
                        SelectedIndex ++;
                        
                    }
                    else if (keyPressed == ConsoleKey.UpArrow)
                    {
                        SelectedIndex --;
                        
                    }
                    
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = 1;
                        
                    }else if (SelectedIndex == 2)
                    {
                        SelectedIndex = 0;
                    }
                    
                }while(keyPressed != ConsoleKey.Enter);
                
            return SelectedIndex;
        }
          
        public static void DisplayItems()
        {
            Console.Clear();
            Console.WriteLine("Welcome to School Cafeteria Ordering System\nPlease Choose your Menu: ");

            Console.WriteLine();

            string[] code = new string[] {"F1","F2","F3","F4","F5","F6","F7", "F8", "F9", "F10", "F11", "F12", "F13", "F14", "F15", "FF"};

            string[] menu = new string[] {"Rice",
                                           "Adobo",
                                           "Menudo",
                                           "Chicken",
                                           "Mami",
                                           "Palabok",
                                           "Lugaw",
                                           "Spaghetti",
                                           "Hotdog Sandwich",
                                           "Burger",
                                           "Kwek-Kwek",
                                           "Siomai",
                                           "Cheese Stick",
                                           "Fries",
                                           "Tokwa",
										   "Finish transaction"};

            decimal[] price = new decimal[] { 15.00m, 40.00m, 40.00m, 35.00m, 35.00m, 25.00m, 25.00m, 25.00m, 25.00m, 25.00m, 20.00m, 25.00m, 20.00m, 20.00m, 20.00m, 0 };
            string strprice = "";
            string transact = "N";
               
            
            do
            {
                Console.Clear();

                //display menu

                Console.WriteLine("Code".PadRight(10) + "Menu".PadRight(30) + "Price".PadRight(20) + "Stock");

                for (int i = 0; i < menu.Length; i++)

                {

                    if (price[i] > 0) 
                    { 
                        strprice = price[i].ToString(); 
                    } 
                    else 
                    {
                        strprice = ""; 
                    }
                    
                    try{
                            
                          Console.WriteLine(code[i].PadRight(10) + menu[i].PadRight(30) + strprice.PadRight(20) + Stocks[i].Item2);
                            
                            
                    }catch(ArgumentOutOfRangeException)
                    {
                        
                    Console.WriteLine(code[i].PadRight(10) + menu[i]);
                            
                    }

                }


                string[] order_list = new string[1];

                int qty;

                string strQty;

                decimal subtotal = 0;

                string order;

                int code_index;

                int order_index = 0;

                decimal grand_total = 0;

                

                do

                {

                    //take orders
            
                    Console.Write("\nEnter Menu Code: ");

                    order = Console.ReadLine().ToUpper();

                    code_index = Array.IndexOf(code, order);
                    if (code_index < 0)
                    {
                        Console.WriteLine("Code Invalid, Please Select Another Option.");
                    }
                    else
                    {
                        if (order != "FF")
                        { 
                          do
                          {                            
                            do
                            {
                                Console.Write("Enter Quantity: ");
                                strQty = Console.ReadLine();
                                if (int.TryParse(strQty, out qty) == false)
                                {
                                    Console.WriteLine("Sorry, Invalid Quantity Value...");
                                }                                                     
                            }
                            while (int.TryParse(strQty, out qty) == false );
                            
                                if(qty > Stocks[code_index].Item2)
                                {
                                    Console.WriteLine("Sorry, Our Stock is Less Than Your Desired Quantity...");
                                }
                          }while(qty > Stocks[code_index].Item2);

                            subtotal = price[code_index] * qty;

                            grand_total = grand_total + subtotal;

                            order_list[order_index] = code[code_index].PadRight(10) + menu[code_index].PadRight(30) +

                                price[code_index].ToString().PadRight(10) +  qty.ToString().PadRight(10) + subtotal.ToString().PadLeft(10);


                            Array.Resize(ref order_list, order_list.Length + 1);
                            Deduct(Stocks[code_index].Item1,qty);
                            
                            
                            order_index++;                            
                        }
                        else
                        {
                            if (grand_total == 0)
                            {
                                int choice = RunMenu();
                                    switch (choice)
                                    {
                                        case 0:
                                            DisplayItems();
                                            break;
                                            
                                        case 1:
                                            RunAuthentication();
                                            break;
                                    }
                            }
                        }

                    }

                } while (order != "FF");
                    
                
                decimal amount_tendered = 0;

                decimal change = 0;

                string str_amount;



                if (grand_total > 0)

                {
                    //display orders
                    Console.WriteLine("\nCode".PadRight(11) + "Menu".PadRight(30) + "Price".PadRight(10) + "Qty".PadRight(10) + "Sub Total".PadLeft(10));
                    for (int i = 0; i < order_list.Length; i++)
                    {
                        Console.WriteLine(order_list[i]);
                    }
                    string str_total = "Total Amount: " + grand_total.ToString("#,0.00");
                    Console.WriteLine(str_total.PadLeft(70));
                    //accept payment and compute change
                    do
                    {
                        do
                        {
                            Console.Write("\nEnter Amount Tendered: ");
                            str_amount = Console.ReadLine();
                        } while (decimal.TryParse(str_amount, out amount_tendered) == false);

                        if (Convert.ToDecimal(str_amount) < grand_total)
                        {
                            Console.WriteLine("Sorry, Amount tendered must be greater than the Total Amount...");
                        }

                    } while (Convert.ToDecimal(str_amount) < grand_total);

                    change = amount_tendered - grand_total;

                    Console.WriteLine("Change: ".PadRight(23) + change.ToString("#,0.00"));

                }

               



                do

                {

                    Console.Write("\nDo you want to make another transaction?:(Y/N): ");

                    transact = Console.ReadLine().ToUpper();

                } while (transact != "Y" && transact !="N");
                

   
        
               

            } while (transact != "N");
           
           int choice1 = RunMenu();
                switch (choice1)
                {
                    case 0:
                        DisplayItems();
                        break;
                        
                    case 1:
                        RunAuthentication();
                        break;
                }
        }
        
        
        public static void RunAuthentication()
        {
             Console.CursorVisible = true;
            Console.Clear();
            string firstLine = "Enter username:";
            string secondLine = "Enter password:";
            string firstButton = "Press 1 to Go Back";
            string secondButton = "Press 2 to Enter";
            
               WriteAt(firstLine,Console.WindowWidth/2 - firstLine.Length,Console.WindowHeight/2 - 1);
               WriteAt(secondLine,Console.WindowWidth/2 - firstLine.Length,Console.WindowHeight/2);
               Console.SetCursorPosition(Console.WindowWidth/2 + 4,Console.WindowHeight/2 - 1);
            Username = Console.ReadLine();    
            
            Console.SetCursorPosition(Console.WindowWidth/2 + 4,Console.WindowHeight/2);
            Password = Console.ReadLine();  
             
            WriteAt(firstButton,Console.WindowWidth/2 - firstButton.Length - 1,Console.WindowHeight/2 + 2);
            WriteAt(secondButton,Console.WindowWidth/2 + 2,Console.WindowHeight/2 + 2);
            ConsoleKey keyPressed;
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed = keyInfo.Key;
                
                
            if(keyPressed == ConsoleKey.D1){
                int choice = RunMenu();
                switch (choice)
                {
                    case 0:
                        DisplayItems();
                        break;
                        
                    case 1:
                        RunAuthentication();
                        break;
                }
            }else if (keyPressed == ConsoleKey.D2){
                if (Username == adminUsername && Password == adminPassword) {
                    Inventory();
                }else{
                    Username = "";
                    Password = "";
                    RunAuthentication();
                }
            }
     
        }
        
        
        public static void Inventory()
        {
            
        	
            Console.Clear();
             ShowSales();
            Console.WriteLine("\nInventory:");
            Console.Write("Stocks for Rice: ");                      
            int food1 = int.Parse(Console.ReadLine());
            
            Console.Write("Stocks for Adobo: ");
            int food2 = int.Parse(Console.ReadLine());
            
            Console.Write("Stocks for Menudo: ");
            int food3 = int.Parse(Console.ReadLine());
            
            Console.Write("Stocks for Chicken: ");
            int food4 = int.Parse(Console.ReadLine());
            
            Console.Write("Stocks for Mami: ");
            int food5 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Palabok: ");
            int food6 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Lugaw: ");
            int food7 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Spaghetti: ");
            int food8 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Hotdog Sandwich: ");
            int food9 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Burger: ");
            int food10 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Kwek-Kwek: ");
            int food11 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Siomai: ");
            int food12 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Cheese Stick: ");
            int food13 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Fries: ");
            int food14 = int.Parse(Console.ReadLine());
            
             Console.Write("Stocks for Tokwa: ");
            int food15 = int.Parse(Console.ReadLine());
            
            Add("Rice",food1);
            Add("Adobo",food2);
            Add("Menudo",food3);
            Add("Chicken",food4);
            Add("Mami",food5);
            Add("Palabok",food6);
            Add("Lugaw",food7);
            Add("Spaghetti",food8);
            Add("Hotdog Sandwich",food9);
            Add("Burger",food10);
            Add("Kwek-Kwek",food11);
            Add("Siomai",food12);
            Add("Cheese Stick",food13);
            Add("Fries",food14);
            Add("Tokwa",food15);
            
            
            Console.WriteLine("\nReturning to MainMenu...");
            Thread.Sleep(3000);
           int choice = RunMenu();
                switch (choice)
                {
                    case 0:
                        DisplayItems();
                        break;
                        
                    case 1:
                        RunAuthentication();
                        break;
                }
                          
            
           
        }
        
        public static void Add(string productName, int qty)
        {
            var stocksIndex = Stocks.FindIndex(p => p.Item1.Equals(productName));
            var stocks = Stocks[stocksIndex];
            Stocks[stocksIndex] = new Tuple<string,int>(stocks.Item1,stocks.Item2 + qty);   
            
            
            
            
        }

        
        public static void Deduct(string productName, int qty)
        {
            var stocksIndex = Stocks.FindIndex(p => p.Item1.Equals(productName));
            var stocks = Stocks[stocksIndex];
            Stocks[stocksIndex] = new Tuple<string,int>(stocks.Item1,stocks.Item2 - qty);
            
            AddSales(productName,qty);
        }
        
        public static void AddSales(string productName, int qty)
        {
            if (!Sales.ContainsKey(productName))
            {
                Sales.Add(productName, qty);
            }
            else
            {
                Sales[productName] = Sales[productName]  +  qty;
            }
        }

        public static void ShowSales()
        {
            Console.WriteLine("Sales:");
    
            var sortedSales = Sales.OrderByDescending(x => x.Value);
             int i = 1;
             
            foreach (var sales in sortedSales)
            {
                Console.WriteLine(i + ". " + sales.Key + " - " + sales.Value + " servings");
                i++;
            }
           
           
        }

    }
}

     
