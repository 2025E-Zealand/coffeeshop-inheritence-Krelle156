using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado: Coffee, IMilk
    {
        public Cortado(float discount) : base(discount)
        {
            
        }

        public override float BasePrice { get { return 25; } }

        public override CoffeeStrength strength { get { return CoffeeStrength.medium; } }

        public int mlMilk { get { return 40; } }
    }
}
