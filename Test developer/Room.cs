using System;
using System.Collections.Generic;
using System.Text;

namespace Test_developer
{
    public class Room
    {
        List<InteractionPoint> points = new List<InteractionPoint>();
        
        public void stayAtRoom()
        {
            for (;;)
            {
                Console.WriteLine("Вы зашли в комнату, в этой комнате есть: ");
                getListOfInteractionPoints();
                int countOfButton = Convert.ToInt32(Console.ReadLine());
                InteractionPoint point = moveToPoint(countOfButton);
                point.intercation();
            }
        }

        public void addInteractionPoint(InteractionPoint point)
        {
            points.Add(point);
        }

        private void getListOfInteractionPoints()
        {
            foreach (InteractionPoint point in points)
            {
                Console.WriteLine((points.IndexOf(point) + 1) + '.'.ToString() + point.GetName());
            }
        }

        private InteractionPoint moveToPoint(int index)
        {
            try
            {
                Console.Clear();
                return points[index - 1];
            }
            catch
            {
                Console.Clear();
                stayAtRoom();
                return null;
            }
        }
    }
}
