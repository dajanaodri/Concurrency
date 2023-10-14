// Shkruani një program C# që simulton një garë të thjeshtë mes dy garuesve.
// Çdo garues duhet të përfaqësohet nga një thread i veçantë.
// Programi kryesor duhet të nisë të dy thread-at njëkohësisht.
// Çdo garues duhet të shfaqë progresin e tyre në garë në intervale të rregullta.
// Garuesi i parë që arrin në vijën e finishit duhet të shpallet fitues.
// Programi juaj duhet të përdorë Thread.Join() për të pritur që garuesi i parë të përfundojë dhe të njoftojë fituesin.


class Race
{
    private static Thread runner1Thread;
    private static Thread runner2Thread;
    public static void Runner1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Garuesi 1 është te checkpoint " + i);
            Thread.Sleep(100); // Simulon progresin e Garuesit 1 (vonesë 100 ms)
        }
        Console.WriteLine("Garuesi 1 ka përfunduar garën!");
    }

    // Simulon progresin për Garuesin 2
    public static void Runner2()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Garuesi 2 është te checkpoint " + i);
            Thread.Sleep(200); // Simulon progresin e Garuesit 2 (vonesë 200 ms)
        }
        Console.WriteLine("Garuesi 2 ka përfunduar garën!");
    }

    public static void Main(string[] args)
    {
        runner1Thread = new Thread(Runner1);
        runner2Thread = new Thread(Runner2);

        // Nis të dy garuesit
        runner1Thread.Start();
        runner2Thread.Start();

        // Pret që garuesi i parë të përfundojë dhe shpall fituesin
        runner1Thread.Join();
        Console.WriteLine("Garuesi 1 fiton!");
        runner2Thread.Join();
        Console.WriteLine("Garuesi 2 doli ne vend te dyte.");

        Console.WriteLine("Simulimi i garës mbaroi.");
    }
}