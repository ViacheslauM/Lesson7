using System.Collections.Generic;

namespace Lesson7
{
    internal class Office
    {
        public string Address { get; private set; }
        public List<Room> Rooms { get; private set; }

        public Office(string adr)
        {
            Address = adr;
            Rooms = new List<Room>(); 
        }
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public string GetTotalOfficeArea()
        {
            string officeFullInfo = null;
            officeFullInfo = $"Rooms area:\n{officeFullInfo}";


            foreach (var room in Rooms)
            {
                officeFullInfo += room.GetRoomArea();
            }

            return $"{officeFullInfo}\n";
        }
    }
}