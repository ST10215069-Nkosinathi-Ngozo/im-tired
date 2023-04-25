namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            circle c = new circle();
            
            triangle t = new triangle();
            
            parallelogram p = new parallelogram();
            
            Console.WriteLine("circle area: " + c.calcArea() + "\ntriangle area: " + 
                t.calcArea() + "\nparallelogram area: " + p.calcArea());
            
            
        }
    }
}