namespace OOP_basics
{
    class Circle
    {
        private float _pi = 3.141f;
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public float GetArea()
        {
            return _radius * _radius * _pi; //Declares how the area is calculated
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle1 = new Circle(5); //Create a circle with the radius 5
            float area1 = circle1.GetArea();
            Console.WriteLine("Arean av en cirkel med radien 5 är: " + area1);

           
            Circle circle2 = new Circle(6); //create a circle with the radius 6
            float area2 = circle2.GetArea();
            Console.WriteLine("Arean av en cirkel med radien 6 är: " + area2);
        }
    }
}