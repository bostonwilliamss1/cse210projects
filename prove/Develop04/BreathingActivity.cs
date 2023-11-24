class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run()
    {
        int totalMilliseconds = _duration * 1000;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalMilliseconds < totalMilliseconds)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            BreatheIn();
            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            BreatheOut();
            Console.WriteLine();
        }
        }
        public void BreatheOut()
        {
        Console.Write("+-+-+-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Thread.Sleep(750);
        Console.Write("\b \b");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Thread.Sleep(2000);
        Console.Write("\b \b");
        }
        public void BreatheIn()
        {
        Console.Write("+");
        Thread.Sleep(250);
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("+");
        Thread.Sleep(750);
        Console.Write("-");
        Thread.Sleep(1500);
        Console.Write("+");
        Thread.Sleep(2000);
        Console.Write("-");
        }


    }
