using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP2
{
    class Program
    {
       
        static double EspressoCost = 2.15;
        static double CappuccinoCost = 4.20;
        static double LatteCost = 5.00;
        static double AmericanoCost = 3.55;
        static double DripCost = 1.25;
        static void Main(string[] args)
        {
            string shot = " ";
            double cost = 0;
            string select = "";
            double shotQuantity = 0;
            string answer = "";

            Dictionary<string, string> Menu = new Dictionary<string, string>();
            List<double> beverageCosts = new List<double>();
            //List<double> Price = new List<double>();
            //MenuItem.Add("Espresso" + "Cappuccino" + "Latte" + "Americano" + "Drip");
            //Price.Add(2.15);
            //Price.Add(4.20);
            //Price.Add(5.00);
            //Price.Add(3.55);
            //Price.Add(1.25);
            Menu.Add("Espresso", "$2.15");
            Menu.Add("Cappuccino", "$4.20");
            Menu.Add("Latte", "$5.00");
            Menu.Add("Americano", "$3.55");
            Menu.Add("Drip", "$1.25");

            Dictionary<string, string> Extra = new Dictionary<string, string>();
            Extra.Add("Shot of Vanilla", "+$0.75 each shot");
            Extra.Add("Shot of Espresso", "+$0.80 each shot");
           
        string start = Console.ReadLine().ToLower();
        if (start == "hello" || start == "hi" || start == "good day")
        {
            Console.WriteLine("I hope you're having a good day! Here is the menu.");
            do
            {

                //Show menu
                foreach (var item in Menu)
                {
                    //Console.Write("Menu Item" + "   " + "Price");
                    Console.WriteLine(item);
                }
            
                //Select drink
                Console.WriteLine("Please select a drink from the menu.");
                select = Console.ReadLine();
                if (Menu.ContainsKey(select)) 
                {
                    switch (select.ToLower())
                    {
                        case "espresso":
                            cost = EspressoCost;
                            break;
                        case "cappuccino":
                            cost = CappuccinoCost;
                            break;
                        case "latte":
                            cost = LatteCost;
                            break;
                        case "americano":
                            cost = AmericanoCost;
                            break;
                        case "drip":
                            cost = DripCost;
                            break;
                    }
                           
                    foreach (var item in Extra)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Would you like to add a type of shot? Y or N");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                       
                        Console.WriteLine("Which shot would you like to add? Vanilla or Espresso?");
                        shot = Console.ReadLine().ToLower();
                        Console.WriteLine("How many shots would you like?");
                        shotQuantity = Convert.ToDouble(Console.ReadLine());

                                if (shot == "vanilla")
                                {
                                    cost += shotQuantity * 0.75;
                                }
                                else
                                {
                                    cost += shotQuantity * .80;
                                }
                        
                    }
              
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid drink! Goodbye!");
                }
            beverageCosts.Add(cost);
            Console.WriteLine("Do you want to add another drink? Y or N");
            } while (Console.ReadLine().ToUpper() == "Y");
                double total = 0;
                for (int i = 0; i < beverageCosts.Count; i++)
                {
                    total += beverageCosts[i];
                }
                Console.WriteLine("Here is your receipt.");
                foreach (var item in beverageCosts)
                {//get this to out put the names with multiple drinks
                   
                        Console.WriteLine($"{select} with {shotQuantity} {shot} shots = {item.ToString("C2")}");
             
                }
            
                double orderTotal = total + (total * .075);
                Console.WriteLine("Your total is = " + orderTotal.ToString("C2"));

        }








        Console.ReadKey();
    }
}
}
