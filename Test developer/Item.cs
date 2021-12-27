using System;
using System.Collections.Generic;
using System.Text;

namespace Test_developer
{
    public class Item
    {
        protected string _name;
        
        public string GetName()
        {
            return _name;
        }

        public void Init(string Name)
        {
            _name = Name;
        }
    }
}
