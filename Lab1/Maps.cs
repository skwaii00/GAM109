using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{ 
     class Maps
    {
        
        public string ID { get; set; }
        public string Name { get; set; }
        public static string _inGame = "liên minh huyền thoại";
        public Maps()
        {

        }
        public Maps(string Id, string name)
        {
            ID = Id;
            Name = name;
        }

        public string ShowData()
        {
            return "ID: " + ID + " |Name: " + Name + " |inGame: " + _inGame;
        }
    }
}
