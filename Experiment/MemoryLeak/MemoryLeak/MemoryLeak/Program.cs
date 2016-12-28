using System;
//This is experiment code from http://crazorsharp.blogspot.com.au/2009/03/net-memory-leaks-it-is-possible.html
//about memery leak.
namespace MemoryLeak
{
    public class Program
    {
        private static EventRaiser raiser;

        private static void Main(string[] args)
        {
            raiser = new EventRaiser();
            for (var i = 0; i < 1000; i++)
            {
                CreateLeak();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        private static void CreateLeak()
        {
            var memoryLeak = new MemoryLeak(raiser);
            memoryLeak = null;
            GC.Collect();
            var memory = GC.GetTotalMemory(true);
            Console.WriteLine("Memory being used: {0:0,0}", memory);
        }
    }

    public class EventRaiser
    {
        private string stringValue;
        public event EventHandler StringValueChanged;

        public string StringValue
        {
            get { return stringValue; }
            set
            {
                if (stringValue != value)
                {
                    stringValue = value;
                    if (StringValueChanged != null)
                    {
                        StringValueChanged(this, new EventArgs());
                    }
                }
            }
        }
    }

    public class MemoryLeak
    {
        private byte[] allocatedMemory;
        private EventRaiser raiser;

        private void raiser_StringValueChanged(object sender, EventArgs e)
        {
        }

        public MemoryLeak(EventRaiser raiser)
        {
            this.raiser = raiser;
            allocatedMemory = new byte[10000];
            raiser.StringValueChanged += raiser_StringValueChanged;
        }
    }
}