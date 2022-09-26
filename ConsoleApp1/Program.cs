Console.WriteLine("press enter to initialize");
Console.ReadLine();

var threads = new List<Thread>();

for (int i = 0; i < 5; i++)
    threads.Add(new Thread(bob.billy.getThreadStart(i == 0)));


foreach (var thrd in threads)
{
    thrd.IsBackground = false;
    thrd.Start();
    Thread.Sleep(1000);
}


Console.WriteLine("started");
Thread.Sleep(50000);

foreach (var thrd in threads)
    thrd.Join();

Console.WriteLine("joined");
Console.ReadLine();
