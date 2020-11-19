using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ruby
{
    public class Objects
    {
        public string Object = "Object";
    }
    public class Item : Objects
    {
        public string Name = "name";

        public Item(string n)
        {
            Name = n;
        }

    }

    //inheritance from https://www.w3schools.com/cs/cs_inheritance.asp
    public class Desc : Objects
    {
        public string Description = "description";

        public Desc(string d)
        {
            Description = d;
        }
    }

}
