namespace Assignment_2_OOP
{
    struct Rectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Width cannot be negative.");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Height cannot be negative.");
                }
                else
                {
                    height = value;
                }
            }
        }

        public double Area
        {
            get { return width * height; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}, Height: {height}, Area: {Area}");
        }
    }

    static class RectangleUtility
    {
        static void Main()
        {
            Rectangle rect = new Rectangle();

            // Setting values via properties
            rect.Width = 3;
            rect.Height = 10;

            // Display rectangle information
            rect.DisplayInfo();

            // Trying to set negative values
            rect.Width = -8;
            rect.Height = -4;
        }
    }
}
