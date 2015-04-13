using System;

namespace PlaceYourOrder.DTO
{
    public abstract class Base
    {
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }
        public virtual string GetById(Enum enumType, string id)
        {
            int result;
            if (Int32.TryParse(id, out result))
                return Enum.GetName(enumType.GetType(), result);
            return string.Empty;        
        }

        public virtual string GetByDesc(string[] listDesc, string descTarget)
        {
            var results = Array.FindAll(listDesc, s => s.Equals(descTarget));
            return results.ToString();
        }
    }
}
