using PlaceYourOrder.DTO.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PlaceYourOrder.DTO
{
    public class Dish : Base
    {
        public bool Error { get; set; }
        public int QuantityEntree { get; set; }
        public int QuantitySide { get; set; }
        public int QuantityDrink { get; set; }
        public int QuantityDessert { get; set; }
        public ArrayList dishList { get; set; }
        const string formatMoreThanOne = "{0}(x{1})";
        const string formatOne = "{0}";

        public Dish()
        {
            dishList = new ArrayList();
        }

        public static List<DTO.Dish> GetList()
        {
            return new List<DTO.Dish>();
        }

        public string GetByCode(int code, Period period)
        {
            string dishSelected = string.Empty;
            switch (code)
            {
                case 1://Entree
                    if (QuantityEntree >= 1)
                        dishSelected = "error";
                    else if (period.Value == PeriodType.Morning.ToString())
                        dishSelected = string.Format(formatOne, Entree.eggs.ToString());
                    else
                        dishSelected = string.Format(Entree.steak.ToString());

                    QuantityEntree++;
                    break;
                case 2://Side
                    if (QuantitySide >= 1 && period.Value == PeriodType.Morning.ToString())
                        dishSelected = "error";
                    else if (period.Value == PeriodType.Morning.ToString())
                    {
                        dishSelected = string.Format(Side.toast.ToString());
                        QuantitySide++;
                    }
                    else
                    {
                        if (QuantitySide >= 1)
                        {
                            dishList.RemoveAt(dishList.Count-1);
                            QuantitySide++;
                            dishSelected = string.Format(formatMoreThanOne, Side.potato.ToString(), QuantitySide);
                        }
                        else
                        {
                            dishSelected = string.Format(Side.potato.ToString());
                            QuantitySide++;
                        }
                    }

                    
                    break;
                case 3://Drink
                    if (QuantityDrink >= 1 && period.Value != PeriodType.Morning.ToString())
                        dishSelected = "error";
                    else if (period.Value == PeriodType.Morning.ToString())
                    {
                        if (QuantityDrink >= 1)
                        {
                            dishList.RemoveAt(dishList.Count - 1);
                            QuantityDrink++;
                            dishSelected = string.Format(formatMoreThanOne, Drink.coffee.ToString(), QuantityDrink);
                        }
                        else
                        {
                            QuantityDrink++;
                            dishSelected = string.Format(Drink.coffee.ToString());
                        }
                    }
                    else
                    {
                        QuantityDrink++;
                        dishSelected = Drink.wine.ToString();
                    }
                   
                    break;
                case 4://Dessert
                    if (QuantityDessert >= 1)
                        dishSelected = "error";
                    if (period.Value == PeriodType.Morning.ToString())
                        dishSelected = string.Format(Dessert.error.ToString());
                    else
                        dishSelected = string.Format(Dessert.cake.ToString());
                    QuantityDessert++;
                    break;
                default://Error
                    dishSelected = "error";
                    break;
            }

            dishList.Add(dishSelected);
            if (dishSelected.Equals("error"))
                Error = true;
            return dishSelected;
            
        }
        public string GetDishTypeFor(string dishCode, Period period)
        {
            int result;
            if (Int32.TryParse(dishCode, out result))
                return GetByCode(result, period);
            return string.Empty;
        }



    }
}
