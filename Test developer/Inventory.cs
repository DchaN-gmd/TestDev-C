using System;
using System.Collections.Generic;
using System.Text;

namespace Test_developer
{
    class Inventory : InteractionPoint
    {
        private List<Item> inventory = new List<Item>();

        public Inventory()
        {
            setName("Инвентарь");
        }

        public override void intercation()
        {
            viewInventory();
        }

        public void getItem(Item item)
        {
            inventory.Add(item);
        }

        public void viewInventory()
        {
            foreach (Item item in inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
