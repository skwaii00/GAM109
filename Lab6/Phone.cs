using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Phone
    {
        public int id;
        public int shop_id;
        public string name;
        public int price;
        public string des;

        public Phone(int id, int shop_id, string name, int price, string des)
        {
            this.id = id;
            this.shop_id = shop_id;
            this.name = name;
            this.price = price;
            this.des = des;
        }
    }
}
