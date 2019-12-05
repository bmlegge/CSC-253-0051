using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailItem
{
    public class Items
    {
        //fields
        private string _description;
        private int _unitsOnHand;
        private decimal _price;

        //default constructor
        public Items()
        {
            _description = null;
            _unitsOnHand = 0;
            _price = 0m;
        }

        //constructor
        public Items(string description, int unitsOnHand, decimal price)
        {
            _description = description;
            _unitsOnHand = unitsOnHand;
            _price = price;
        }

        //Description property
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        
        //UnitsOnHand property
        public int UnitsOnHand
        {
            get { return _unitsOnHand; }
            set { _unitsOnHand = value; }
        }

        //Price property
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
