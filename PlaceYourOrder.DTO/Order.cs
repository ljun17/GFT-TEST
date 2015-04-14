using System.Collections.Generic;

namespace PlaceYourOrder.DTO
{
    public class Order
    {
        readonly Period _period;
        readonly  List<Dish> _dish;

        public Order(Period period, List<Dish>  dish)
        {
            _period = period;
            _dish = dish;
        }

        public Period Type { get; set; }
        public List<Dish> Dishes { get; set; }

    }
}
