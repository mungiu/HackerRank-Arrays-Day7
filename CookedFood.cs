using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APFoodEquals
{
    //sealed class, means nothing else will ever derive from it
    //affects how we implement equality
    public sealed class CookedFood : Food
    {
        //tells you how the food is cooked
        private string _cookingMethod;

        public string CookingMethod { get { return _cookingMethod; } }

        //constructor with additional parameter
        public CookedFood(string cookingMethod, string name, FoodGroup group)
            : base(name, group)
        {
            this._cookingMethod = cookingMethod;
        }

        //concatinated the cooking method and the name
        public override string ToString()
        {
            {
                return string.Format("{0} {1}", _cookingMethod, Name);
            }
        }
    }
}
