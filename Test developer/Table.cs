using System;
using System.Collections.Generic;

namespace Test_developer
{
    public class Table : InteractionPoint
    {
        private List<Item> itemOnTable = new List<Item>();

        public Table()
        {
            setName("Стол");
        }

        public override void intercation()
        {
            for (; ; )
            {
                Console.WriteLine("0.Отойти от стола.");
                getListOfItems();
                int index = Convert.ToInt32(Console.ReadLine());
                if (index == 0)
                {
                    Console.Clear();
                    Program.GoToRoom();                    
                }
                takeItem(index);
            }
        }
        //Скверное решение, но попытка на закос возможной внешней инициализации через рандомайзер
        public void InitItem()
        {
            Item coins = new Item();
            Item amulet = new Item();
            Item book = new Item();
            coins.Init("33 Монетки");
            amulet.Init("Амулет");
            book.Init("Книга");
            addItemOnTable(coins);
            addItemOnTable(amulet);
            addItemOnTable(book);
        }

        private void addItemOnTable(Item item)
        {
            itemOnTable.Add(item);
        }

        private void getListOfItems()
        {
            foreach (Item item in itemOnTable)
            {
                Console.WriteLine((itemOnTable.IndexOf(item) + 1) + ".Подобрать: ".ToString() + item.GetName());
            }
        }

        private Item takeItem(int indexItem)
        {
            try
            {
                Item item = itemOnTable[indexItem - 1];
                itemOnTable.Remove(itemOnTable[indexItem - 1]);
                Console.Clear();
                return item;
            }
            catch
            {
                intercation();
                Console.Clear();
                return null;
            }
        }
    }
}
