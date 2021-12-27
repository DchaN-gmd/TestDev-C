using System;
using System.Collections.Generic;
using System.Text;

namespace Test_developer
{
    class GameContoller
    {
        Inventory inventory = new Inventory();
        Room room = new Room();
        Table table = new Table();


        private void stateChanged()
        {
            inventory.stateChanged += chekState;
            room.stateChanged += chekState;
            table.stateChanged += chekState;
        }
         public void chekState(PlayerState state)
        {
            switch(state)
            {
                case PlayerState.StayAtRoom:
                    room.stayAtRoom();
                    break;
                case PlayerState.StayAtTable:
                    table.intercation();
                    break;
                case PlayerState.LookAtInventory:
                    inventory.intercation();
                    break;
            }
        }
    }
}
