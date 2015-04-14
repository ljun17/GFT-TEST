using System;

namespace PlaceYourOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine(" -------------MENU----------------");
            Console.WriteLine("Dish Type   | Morning | Night");
            Console.WriteLine(" ---------------------------------");
            Console.WriteLine("1 (Entrée)  | Eggs    | Steak");
            Console.WriteLine("2 (Side)    | Toast   | Potato");
            Console.WriteLine("3 (Drink)   | Coffee  | Wine");
            Console.WriteLine("4 (Dessert) |         | Cake");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enter the period and the code of the items.");
            Console.WriteLine("Ex: night, 1,2,2,4");
            Console.WriteLine("==================================");
            Console.WriteLine("");

            try
            {
                string commands = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(commands))
                    throw new Exception("Periods requested do not exist");

                Console.WriteLine(OrderingService.TakeOrder(commands));
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.Read();
            }
            finally
            {

            }
        }
    }
}
