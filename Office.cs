using System.Collections.Generic;

namespace Lesson7
{
    class Office
    {
        public string Address { get; private set; }
        public List<Room> Rooms { get; private set; }

        public Office(string adr, List<Room> rms)
        {
            Address = adr;
            Rooms = rms;
        }

        public string GetArea()
        {
            var totalArea = 0.0;
            foreach (Room room in Rooms)
            {
                totalArea += room.Width * room.Length;
            }

            return totalArea.ToString();
        }
    }


}
