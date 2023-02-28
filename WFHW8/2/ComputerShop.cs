using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHW8
{
    public class ComputerShop
    {
        public string name;
        public List<Accessories> accessories;
        public string descr;
        public decimal price;

        public ComputerShop(string _name, List<Accessories> _accessories, string _descr, int _price)
        {
            this.name = _name;
            this.accessories = _accessories;
            this.descr = _descr;
            this.price = _price;
        }
        public ComputerShop(ComputerShop computer)
        {
            this.name = computer.name;
            this.descr=computer.descr;
            this.price = computer.price;
            this.accessories = new List<Accessories>(computer.accessories);
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
