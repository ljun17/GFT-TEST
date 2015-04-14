using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlaceYourOrder.DTO.Enums;

namespace PlaceYourOrder.DTO
{
    public class Entree
    {
        public int QuantityEntree { get; set; }
        const string formatMoreThanOne = "{0}(x{1})";        

        public string GetEntreeMorning()
        {
            sumQuantity();
            return DTO.Enums.Entree.eggs.ToString();
        }

        public string GetEntreeNight()
        {
            sumQuantity();
            return DTO.Enums.Entree.steak.ToString();
        }

        public int getQuantity()
        {
            return QuantityEntree;
        }

        private void sumQuantity()
        {
            QuantityEntree++;
        }
    }
}
