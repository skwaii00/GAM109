using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Shop
    {
        public int id;
        public string shopname;
        public string address;

        public Shop(int id, string shopname, string address)
        {
            this.id = id;
            this.shopname = shopname;
            this.address = address;
        }
    }
}
