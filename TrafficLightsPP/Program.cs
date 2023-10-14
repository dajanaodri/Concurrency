class TrafficLight
{
    private enum NgjyraSinjalizimit { E_Kuqe, E_Verdhe, E_Gjelbër }
    private NgjyraSinjalizimit ngjyraAktuale;

    public TrafficLight()
    {
        ngjyraAktuale = NgjyraSinjalizimit.E_Kuqe;
    }

    public void StartSinjaliziminRrugor()
    {
        // Fillimi i një simulimi për ngjyrën e sinjalizimit rrugor
        Parallel.Invoke(
            () =>
            {
                while (true)
                {
                    Console.WriteLine($"Ngjyra e sinjalizimit rrugor është {ngjyraAktuale}");
                    Task.Delay(200).Wait(); // Pauza për 0.2 sekonda (simulimi i ndryshimit të ngjyrës së sinjalizimit)

                    // Ndrysho ngjyrën e sinjalizimit rrugor sipas një seri ngjarjesh
                    ngjyraAktuale = ngjyraAktuale switch
                    {
                        NgjyraSinjalizimit.E_Kuqe => NgjyraSinjalizimit.E_Gjelbër,
                        NgjyraSinjalizimit.E_Verdhe => NgjyraSinjalizimit.E_Kuqe,
                        NgjyraSinjalizimit.E_Gjelbër => NgjyraSinjalizimit.E_Verdhe,
                    };
                }
            }
        );
    }
}

class Program
{
    static void Main(string[] args)
    {
        TrafficLight sinjalizimiRrugor = new TrafficLight();

        // Krijo një instancë të klases TrafficLight për simulimin e sinjalizimit rrugor
        sinjalizimiRrugor.StartSinjaliziminRrugor(); // Nisni simulimin e sinjalizimit rrugor
    }
}
