using System;
using System.Collections.Generic;
using System.Text;

namespace Test_developer
{
    public abstract class InteractionPoint
    {
        private string Name;

        public abstract void intercation();
        protected void setName(string name) { Name = name; }

        public string GetName() { return Name; } 
        
    }
}
