using System.Collections.Generic;
using Lesson7;

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
