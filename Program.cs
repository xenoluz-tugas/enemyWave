
for (int wave = 1; wave <= 100; wave++)
{
    Console.WriteLine($"On the wave {wave}.");
    System.Threading.Thread.Sleep(300);
    Console.WriteLine($"Starting wave {wave}, character is fighting..");
    System.Threading.Thread.Sleep(600);
    Console.WriteLine($"Closing wave {wave}, character is on the way to the next wave.\n");
    System.Threading.Thread.Sleep(300);
}