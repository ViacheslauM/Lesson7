using System.Collections.Generic;

namespace Lesson6
{
    class RoomComparer : IComparer<Room>
    {
        public int Compare(Room x, Room y)
        {
            return (int) ((x.Width * x.Length) - (y.Width * y.Length));
        }
    }
}
