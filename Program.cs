using System.ComponentModel;

namespace TaskFight
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            Thread firstThread;            
            Thread secondThread;
            
            firstThread = new Thread(() =>
            {
                int i;
                for (i = 1; i <= 500; i++)
                {
                    
                    
                }
                Console.WriteLine();
            });
            secondThread = new Thread(() =>
            {
                for (int i = 0; i >= -500; i--)
                {
                    Console.Write($"\t\t{i}");
                }
            });
            firstThread.Start();
            secondThread.Start();
            if (!firstThread.IsAlive) {
                secondThread = null;
            }
            else if (!secondThread.IsAlive)
            {
                firstThread = null;
            }
            
        }
    }
}