namespace Assignment_2_OOP
{
    struct Point
    {
        public double X;
        public double Y;
    }

    static class CalculateDistanceProgram
    {
        static void Main()
        {
            Point point1, point2;

            Console.Write("Enter the X coordinate of the first point: ");
            point1.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Y coordinate of the first point: ");
            point1.Y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the X coordinate of the second point: ");
            point2.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Y coordinate of the second point: ");
            point2.Y = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            Console.WriteLine($"The distance between the two points is: {distance}");
        }
    }
}
