using System;
using System.Threading;
using System.Threading.Tasks;

class Gara
{
    public static async Task Garuesi1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Garuesi 1 është te checkpoint " + i);
            await Task.Delay(200); // Simulimi i progresit të garuesit 1
        }
        Console.WriteLine("Garuesi 1 ka përfunduar garën!");
    }

    public static async Task Garuesi2()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Garuesi 2 është te checkpoint " + i);
            await Task.Delay(100); // Simulimi i progresit të garuesit 2
        }

        Console.WriteLine("Garuesi 2 ka përfunduar garën!");
    }

    public static async Task Main(string[] args)
    {

        var garuesi1Task = Garuesi1();
        var garuesi2Task = Garuesi2();

        await Task.WhenAny(garuesi1Task, garuesi2Task);

        Console.WriteLine("Simulimi i garës mbaroi.");
    }
}
