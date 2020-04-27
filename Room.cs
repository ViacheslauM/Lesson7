namespace Lesson7
{
    class Room
    {
        public double Length{ get; private set; }
        public double Width { get; private set; }

        public Room(double length, double width)
        {
            Length = length;
            Width = width;
        }
    }
}
