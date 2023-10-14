using System.Threading;//na mundeson te punojme me thread-e
namespace Multithreading
{
    class Program
    {
        //thread= nje path i executimit te programit
        //mund te perdorim disa thread-e per te kryer
        //pune te ndryshme brenda programit ne te
        //njejten kohe 
        public static void Main(string[] args)
        {
            //kur startojme nje console app kemi
            //1 thread -- Main thread

            //marrim thradin me te cilin po punojme aktualisht
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Thread-i kryesor";
            Console.WriteLine(mainThread.Name);

            //therrasim metodat e timer ne threadin kryesor
            //do na ekzekutohen nje pas tjetres
            //CountDown();
            //CountUp();
            //Console.WriteLine(mainThread.Name + " mbaroi ekzekutimin");

            //per ti ekzekutuar ne te njejten kohe do na duhet
            //te krijojme dy threade te tjera 
            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            ////nese duam te therrasim nje metode me parametra perdorim lambda expression
            //Thread thread3 = new Thread(() => CountDown("Timer 3"));
            thread1.Start();
            thread2.Start();
        }

        //supozojme se kemi 2 numerues qe po ekzekutohen njekohesisht
        //njeri numeron nga 0 te 10
        //tjetri nga 10 tek 0
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer nr 1: " + i + "sekonda");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer nr 1 mbaroi.");
        }
        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer nr 1: " + i + "sekonda");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer nr 1 mbaroi.");
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer nr 2: " + i + "sekonda");
                Thread.Sleep(1000);//ndalon perkohesisht threadin per 1000 miliseconda
            }
            Console.WriteLine("Timer nr 2 mbaroi.");
        }
    }
}