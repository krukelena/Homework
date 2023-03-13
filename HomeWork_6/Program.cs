namespace HomeWork_6;

 internal class Program { 
    
    public static void Main(string[] args)
    {


        Figure[] figures = new Figure[6];

        figures[0] = TriangleLog.CreateTriangle(10, 7, 15);
        figures[1] = TriangleLog.CreateTriangle(3, 4, 5);
        figures[2] = TriangleLog.CreateTriangle(5, 5, 2);
        figures[3] = TriangleLog.CreateTriangle(3, 3, 3);

        figures[4] = new Square(10);
        figures[5] = new Rectangle(5, 10);

        foreach (Figure figure in figures)
            Console.WriteLine(figure.Area);
    }
 }
