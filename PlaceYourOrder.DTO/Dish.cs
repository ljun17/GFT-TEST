using PlaceYourOrder.DTO.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PlaceYourOrder.DTO
{
    public class Dish : DishesBase
    {
        public bool Error { get; set; }
        public ArrayList dishList { get; set; }
        private Entree entree { get; set; }
        private Side side { get; set; }
        private Drink drink { get; set; }
        private Dessert dessert { get; set; }

        public Dish()
        {
            dishList = new ArrayList();
            entree = new Entree();
            side = new Side();
            drink = new Drink();
            dessert = new Dessert();
        }

        public string GetByCode(int code, Period period)
        {
            string dishSelected = string.Empty;
            switch (code)
            {
                case 1://Entree
                    if (entree.getQuantity() >= 1)
                        this.Error = true;
                    else if (period.Value == PeriodType.Morning.ToString())
                        dishSelected = entree.GetEntreeMorning();
                    else
                        dishSelected = entree.GetEntreeNight();
                    break;
                case 2://Side
                    if (side.getQuantity() >= 1 && period.Value == PeriodType.Morning.ToString())
                        this.Error = true;
                    else if (period.Value == PeriodType.Morning.ToString())
                    {
                        dishSelected = side.GetSideMorning();
                    }
                    else if (side.getQuantity() >= 1)
                    {
                        dishList.RemoveAt(dishList.Count - 1);
                        dishSelected = side.GetSideNightMoreThanOne();
                    }
                    else
                        dishSelected = side.GetSideNightOne();

                    break;
                case 3://Drink
                    if (drink.getQuantity() >= 1 && period.Value != PeriodType.Morning.ToString())
                        this.Error = true;
                    else if (period.Value == PeriodType.Night.ToString())
                    {
                        dishSelected = drink.GetDrinkNight();
                    }
                    else if (drink.getQuantity() >= 1)
                    {
                        dishList.RemoveAt(dishList.Count - 1);
                        dishSelected = drink.GetDrinkMorningMoreThanOne();
                    }
                    else
                        dishSelected = drink.GetDrinkMorningOne();

                    break;
                case 4://Dessert
                    if (dessert.getQuantity() >= 1)
                        this.Error = true;
                    if (period.Value == PeriodType.Morning.ToString())
                        dishSelected = dessert.GetDessertMorning();
                    else
                        dishSelected = dessert.GetDessertNight();
                    break;
                default://Error
                    this.Error = true;;
                    break;
            }

            if(this.Error == true)
                dishList.Add("error");
            else
                dishList.Add(dishSelected);
            
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
