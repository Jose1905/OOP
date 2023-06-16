using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();

        Square newSquare = new Square("Red", 4);
        shapeList.Add(newSquare);

        Circle newCircle = new Circle("Blue", 4);
        shapeList.Add(newCircle);

        Rectangle newRectangle = new Rectangle("Green", 4, 6);
        shapeList.Add(newRectangle);

        for(int i = 0; i < shapeList.Count(); i ++){
            Console.WriteLine(shapeList[i].GetColor());
            Console.WriteLine(shapeList[i].GetArea());
        }
    }
}