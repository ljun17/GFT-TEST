using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace PlaceYourOrder.DTO
{
    public class Drink
    {
        public int QuantityDrink { get; set; }
        const string formatMoreThanOne = "{0}(x{1})";

        public string GetDrinkMorningOne()
        {
            sumQuantity();
            return DTO.Enums.Drink.coffee.ToString();            
        }

        public string GetDrinkMorningMoreThanOne()
        {
            
            sumQuantity();
            return string.Format(formatMoreThanOne, DTO.Enums.Drink.coffee.ToString(), QuantityDrink);            
        }

        public string GetDrinkNight()
        {
            sumQuantity();
            return DTO.Enums.Drink.wine.ToString();            
        }

        public int getQuantity()
        {
            return QuantityDrink;
        }

        private void sumQuantity()
        {
            QuantityDrink++;
        }
    }
}
