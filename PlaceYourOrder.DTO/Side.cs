using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceYourOrder.DTO
{
    public class Side
    {
        public int QuantitySide { get; set; }
        const string formatMoreThanOne = "{0}(x{1})";

        public string GetSideMorning()
        {
            sumQuantity();
            return DTO.Enums.Side.toast.ToString();
        }

        public string GetSideNightOne()
        {
            sumQuantity();
            return DTO.Enums.Side.potato.ToString();
        }

        public string GetSideNightMoreThanOne()
        {
            sumQuantity();
            return string.Format(formatMoreThanOne, DTO.Enums.Side.potato.ToString(), QuantitySide);
            
        }

        public int getQuantity()
        {
            return QuantitySide;
        }

        private void sumQuantity()
        {
            QuantitySide++;
        }
    }
}
