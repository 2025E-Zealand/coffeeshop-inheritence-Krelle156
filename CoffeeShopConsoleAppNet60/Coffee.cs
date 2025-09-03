using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public float Discount { get; set; }

        protected Coffee(float discount)
        {
            Discount = discount;
        }

        public virtual float BasePrice { get { return 20; } }
        public virtual float Price 
        { get 
            {
                float flatDiscount = BasePrice*Discount;
                if(flatDiscount>5)
                {
                    throw new PolicyException("Discount cannot be more than 5");
                }
                return BasePrice-flatDiscount; 
            } 
        }

        public abstract CoffeeStrength strength { get; }
    }
}
