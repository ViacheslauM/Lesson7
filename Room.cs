namespace Lesson6
{
    internal class Room
    {
        public double Length{ get; private set; }
        public double Width { get; private set; }

        public Room(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public string GetRoomArea()
        {
            var area = 0.0;
            area += Width * Length;

            return ($"{area.ToString()}\n");
        }
    }
}
