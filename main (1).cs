using System;

// Інтерфейс для чотирикутника, заданого довжинами сторін
public interface IQuadrilateralBySides
{
    double CalculateArea();
    double CalculatePerimeter();
    string DetermineType();
}

// Інтерфейс для чотирикутника, заданого координатами вершин
public interface IQuadrilateralByVertices
{
    double CalculateArea();
    double CalculatePerimeter();
    string DetermineType();
}

// Клас чотирикутника
public class Quadrilateral : IQuadrilateralBySides, IQuadrilateralByVertices
{
    private double[] sides;
    private double[,] vertices;

    // Конструктор для чотирикутника за довжинами сторін
    public Quadrilateral(params double[] sides)
    {
        if (sides.Length != 4)
        {
            throw new ArgumentException("A quadrilateral must have exactly 4 sides.");
        }
        this.sides = sides;
    }

    // Конструктор для чотирикутника за координатами вершин
    public Quadrilateral(double[,] vertices)
    {
        if (vertices.GetLength(0) != 4 || vertices.GetLength(1) != 2)
        {
            throw new ArgumentException("A quadrilateral must have exactly 4 vertices with 2 coordinates each.");
        }
        this.vertices = vertices;
    }

    // Реалізація методів для чотирикутника, заданого довжинами сторін
    public double CalculateArea()
    {
        // Реалізація обчислення площі для чотирикутника, заданого довжинами сторін
        return 0;
    }

    public double CalculatePerimeter()
    {
        // Реалізація обчислення периметра для чотирикутника, заданого довжинами сторін
        return 0;
    }

    public string DetermineType()
    {
        // Реалізація визначення типу для чотирикутника, заданого довжинами сторін
        return "";
    }

    // Реалізація методів для чотирикутника, заданого координатами вершин
    double IQuadrilateralByVertices.CalculateArea()
    {
        // Реалізація обчислення площі для чотирикутника, заданого координатами вершин
        return 0;
    }

    double IQuadrilateralByVertices.CalculatePerimeter()
    {
        // Реалізація обчислення периметра для чотирикутника, заданого координатами вершин
        return 0;
    }

    string IQuadrilateralByVertices.DetermineType()
    {
        // Реалізація визначення типу для чотирикутника, заданого координатами вершин
        return "";
    }
}

class Program
{
    static void Main(string[] args)
    {
        double[] sides = new double[4];
        double[,] vertices = new double[4, 2];

        Console.WriteLine("Enter 1 to input sides or 2 to input vertices:");
        int inputType = int.Parse(Console.ReadLine());

        if (inputType == 1)
        {
            Console.WriteLine("Enter the lengths of the 4 sides:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Side " + (i + 1) + ": ");
                sides[i] = double.Parse(Console.ReadLine());
            }

            // Створення чотирикутника за довжинами сторін
            Quadrilateral quadBySides = new Quadrilateral(sides);
            Console.WriteLine("Area: " + quadBySides.CalculateArea());
            Console.WriteLine("Perimeter: " + quadBySides.CalculatePerimeter());
            Console.WriteLine("Type: " + quadBySides.DetermineType());
        }
        else if (inputType == 2)
        {
            Console.WriteLine("Enter the coordinates of the 4 vertices (x y):");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Vertex " + (i + 1) + ": ");
                string[] coordinates = Console.ReadLine().Split(' ');
                vertices[i, 0] = double.Parse(coordinates[0]);
                vertices[i, 1] = double.Parse(coordinates[1]);
            }

            // Створення чотирикутника за координатами вершин
            Quadrilateral quadByVertices = new Quadrilateral(vertices);
            Console.WriteLine("Area: " + ((IQuadrilateralByVertices)quadByVertices).CalculateArea());
            Console.WriteLine("Perimeter: " + ((IQuadrilateralByVertices)quadByVertices).CalculatePerimeter());
            Console.WriteLine("Type: " + ((IQuadrilateralByVertices)quadByVertices).DetermineType());
        }
        else
        {
            Console.WriteLine("Invalid input type.");
        }
    }
}


