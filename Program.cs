using System;

public abstract class Graph
{
    public abstract void Draw();
}
public class LineGraph : Graph
{
    public override void Draw()
    {
        Console.WriteLine("Відображення лінійного графіка");
    }
}

public class BarGraph : Graph
{
    public override void Draw()
    {
        Console.WriteLine("Відображення стовпчикового графіка");
    }
}

public class PieChart : Graph
{
    public override void Draw()
    {
        Console.WriteLine("Відображення кругової діаграми");

    }
}

public class GraphFactory
{
    public Graph CreateGraph(string type)
    {
        switch (type.ToLower())
        {
            case "line":
                return new LineGraph();
            case "bar":
                return new BarGraph();
            case "pie":
                return new PieChart();
            default:
                throw new ArgumentException("Непідтримуваний тип графіка");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть тип графіка (line, bar або pie):");
        string graphType = Console.ReadLine();

        GraphFactory factory = new GraphFactory();
        Graph graph = factory.CreateGraph(graphType);

        graph.Draw();
    }
}
