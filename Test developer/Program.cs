namespace Test_developer
{

    class Program
    {
        static void Main(string[] args)
        { 
          GoToRoom();
        }
         
        static public void GoToRoom()
        {
            Room room = new Room();
            Table table = new Table();
            table.InitItem();
            room.addInteractionPoint(table);
            room.stayAtRoom();
        }

    }
}
