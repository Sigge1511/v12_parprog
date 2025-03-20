using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v12_parprog
{
    public class ConsoleManager
    {
        internal ShopCntxt dbctx = new ShopCntxt();
        private ShopRepository shoprepo = new ShopRepository();
        public void Run()
        {
            PrintMenu();
            Console.ReadKey();
        }

        internal void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("MENY:\n");
            Console.WriteLine("1. Lägg till en kund");
            Console.WriteLine("2. Ändra en kund");
            Console.WriteLine("3. Skriv ut alla kunder");
            Console.WriteLine("4. Ta bort en kund");
            Console.WriteLine("5. Lägg till en order");
            Console.WriteLine("6. Ändra en order");
            Console.WriteLine("7. Ta bort en order");
            Console.WriteLine("8. Skriv ut alla ordrar hos en kund");
            Console.WriteLine("9. Avsluta programmet");
            Console.WriteLine("\nVälj ett alternativ genom att skriva in en siffra:\n");
            MenuSelection();
        }
        internal void MenuSelection()
        {
            int selection = 0;
            bool parseselec = false;
            while (parseselec == false)
            {
                parseselec = int.TryParse(Console.ReadLine(), out selection);
                if (selection < 1 || selection > 9 || parseselec == false)
                {
                    Console.WriteLine("Ogiltigt val. Vänligen försök igen.\n");
                    parseselec = false;
                }
                else { parseselec = true; }
            }
            MenuHandler(selection);
        }
        internal void MenuHandler(int selection)
        {
            switch (selection)
            {
                case 1:
                    Console.Clear();
                    AddCustomer();
                    break;

                case 2:
                    Console.Clear();
                    ModifyCustomer();
                    break;

                case 3:
                    Console.Clear();
                    PrintAllCustomers();
                    break;

                case 4:
                    Console.Clear();
                    DeleteCustomer();
                    break;
                case 5:
                    Console.Clear();
                    AddOrder();
                    break;
                case 6:
                    Console.Clear();
                    ModifyOrder();
                    break;
                case 7:
                    Console.Clear();
                    DeleteOrder();
                    break;
                case 8:
                    Console.Clear();
                    PrintCustomerOrders();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Programmet avslutas nu");
                    break;
            }
        }
        //*****************************************************************************************
        internal void AddCustomer() 
        {


            ReturnToMenu();
        }
        internal void ModifyCustomer()
        {

            ReturnToMenu();
        }
        internal void PrintAllCustomers()
        {

            ReturnToMenu();
        }
        internal void DeleteCustomer()
        {

            ReturnToMenu();
        }
        internal void AddOrder()
        {

            ReturnToMenu();
        }
        internal void ModifyOrder()
        {

            ReturnToMenu();
        }
        internal void DeleteOrder()
        {

            ReturnToMenu();
        }
        internal void PrintCustomerOrders()
        {

            ReturnToMenu();
        }
        //*****************************************************************************************
        internal int CustomerSelection()
        {
            int customerid = 0;

            return customerid;
        }
        internal int OrderSelection()
        {
            int orderid = 0;

            return orderid;
        }
        internal void ReturnToMenu()
        {
            Console.WriteLine("\nTryck enter för att återgå till menyn");
            Console.ReadKey();
            Console.Clear();
            PrintMenu();
        }
    }
}
