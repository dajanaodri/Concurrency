// Shkruani një aplikacion C# që simulon një sistem të thjeshtë sinjalizimi rrugor.
// Sinjalizimi rrugor duhet të ketë tre gjendje: kuq, verdhë dhe gjelbër.
// Programi juaj duhet të përdorë multithreading për të ndryshuar sinjalizimin rrugor
// midis këtyre gjendjeve në një mënyrë ciklike. Mund të përdorni timer, threads,
// ose çdo metodë tjetër që preferoni për të kryer këtë simulim.

// Programi juaj duhet të shfaqë gjendjen aktuale të sinjalizimit rrugor
// (p.sh., "Kuq," "Verdhë," "Gjelbër") dhe të kalohet në gjendjen tjetër
// në intervale të rregullta (p.sh., Kuq -> Gjelbër -> Verdhe -> Kuq).

class Program
{
    static void Main(string[] args)
    {
        SinjalizimiRrugor sinjalizimiRrugor = new SinjalizimiRrugor();

        // Nisni një thread për simulimin e sinjalizimit rrugor
        Thread threadSinjalizimiRrugor = new Thread(sinjalizimiRrugor.NisSinjaliziminRrugor);
        threadSinjalizimiRrugor.Start();

        // Pritni që thread-i të përfundojë (kjo nuk do të ndodhë kurrë në këtë shembull)
        threadSinjalizimiRrugor.Join();
    }
}

class SinjalizimiRrugor
{
    private enum NgjyraSinjalizimit { E_Kuqe, E_Verdhe, E_Gjelbër }
    private NgjyraSinjalizimit ngjyraAktuale;

    public SinjalizimiRrugor()
    {
        ngjyraAktuale = NgjyraSinjalizimit.E_Kuqe;
    }

    public void NisSinjaliziminRrugor()
    {
        while (true)
        {
            Console.WriteLine($"Sinjalizimi rrugor është {ngjyraAktuale}");

            // Ndrysho ngjyrën e sinjalizimit rrugor
            switch (ngjyraAktuale)
            {
                case NgjyraSinjalizimit.E_Kuqe:
                    ngjyraAktuale = NgjyraSinjalizimit.E_Gjelbër;
                    break;
                case NgjyraSinjalizimit.E_Verdhe:
                    ngjyraAktuale = NgjyraSinjalizimit.E_Kuqe;
                    break;
                case NgjyraSinjalizimit.E_Gjelbër:
                    ngjyraAktuale = NgjyraSinjalizimit.E_Verdhe;
                    break;
            }

            // Përsëritet për një interval të caktuar (p.sh., 2 sekonda)
            Thread.Sleep(2000);
        }
    }
}
