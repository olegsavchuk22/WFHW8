using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHW8
{
    public class Accessories
    {
        public string name;
        public decimal price;

        public Accessories(string _name, decimal _price)
        {
            this.name = _name;
            this.price = _price;
        }
        public Accessories(Accessories accessories)
        {
            this.name=accessories.name;
            this.price=accessories.price;
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
