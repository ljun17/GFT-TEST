using System;


namespace PlaceYourOrder
{
    public class OrderingService
    {
        public static string TakeOrder(string commands)
        {
            var orders = commands.Split(',');
            DTO.Period period = DTO.Period.Get(orders[0].Trim());
            Array.Sort(orders);                    
            DTO.Dish dish = new DTO.Dish();
            
            
            for (int i = 0; i < orders.Length-1; i++)
            {   
                dish.GetDishTypeFor(orders[i].Trim(), period);
                if (dish.Error)
                    break;                
            }

            return string.Join(", ", (string[])dish.dishList.ToArray(Type.GetType("System.String")));            
        }
    }
}
