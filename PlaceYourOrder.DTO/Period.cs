using PlaceYourOrder.DTO.Enums;
using System;

namespace PlaceYourOrder.DTO
{
    public class Period  : Base
    {        
        public string Value { get; set; }
        public Period(string period)
        {
            Value = period;
        }

        static public Period Get(string target)
        {
            string[] listPeriodType = Enum.GetNames(typeof(PeriodType));

            var results = Array.FindAll(listPeriodType, s => s.ToLower().Equals(target.ToLower()));
            if (results.Length > 0)
                return new Period(results[0]);
            else
                throw new PlaceYourOrder.Exception.CustomException("Periods requested do not exist");
        }
    }
}
