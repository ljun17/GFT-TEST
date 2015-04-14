using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceYourOrder.DTO
{
    public class Dessert
    {
        public int QuantityDessert { get; set; }
        const string formatMoreThanOne = "{0}(x{1})";

        public string GetDessertMorning()
        {
            sumQuantity();
            return DTO.Enums.Dessert.error.ToString();
        }

        public string GetDessertNight()
        {
            sumQuantity();
            return DTO.Enums.Dessert.cake.ToString();
        }

        public int getQuantity()
        {
            return QuantityDessert;
        }

        private void sumQuantity()
        {
            QuantityDessert++;
        }
    }
}
