using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte(float discount) : base(discount)
        {
            
        }

        public override float BasePrice { get { return 40; } }

        public override CoffeeStrength strength { get { return CoffeeStrength.weak; } }

        public int mlMilk { get { return 400; } }
    }
}
