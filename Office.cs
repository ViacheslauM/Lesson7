namespace Lesson7
{
    class Office
    {
        public string Address { get; private set; }
        public Room[] Rooms { get; private set; }

        public Office(string adr, Room[] rms)
        {
            Address = adr;
            Rooms = rms;
        }

        public double GetArea()
        {
            double totalArea = 0.0;
            foreach (Room room in Rooms)
            {
                totalArea += room.Width * room.Length;
            }

            return totalArea;
        }
    }


}
