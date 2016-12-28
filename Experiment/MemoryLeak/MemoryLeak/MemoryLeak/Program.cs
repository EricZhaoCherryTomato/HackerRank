using System;
//This is experiment code from http://crazorsharp.blogspot.com.au/2009/03/net-memory-leaks-it-is-possible.html
//about memery leak.
namespace MemoryLeak
{
    public class Program
    {
        private static EventRaiser _raiser;

        private static void Main(string[] args)
        {
            _raiser = new EventRaiser();
            for (var i = 0; i < 1000; i++)
            {
                CreateLeak();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        private static void CreateLeak()
        {
            var memoryLeak = new MemoryLeak(_raiser);
            memoryLeak.Dispose();//Call dispose method before set memory to null
            memoryLeak = null;
            GC.Collect();
            var memory = GC.GetTotalMemory(true);
            Console.WriteLine("Memory being used: {0:0,0}", memory);
        }
    }

    public class EventRaiser
    {
        private string _stringValue;
        public event EventHandler StringValueChanged;

        public string StringValue
        {
            get { return _stringValue; }
            set
            {
                if (_stringValue != value)
                {
                    _stringValue = value;
                    StringValueChanged?.Invoke(this, new EventArgs());
                }
            }
        }
    }

    public class MemoryLeak :IDisposable
    {
        private byte[] _allocatedMemory;
        private EventRaiser _raiser;

        private void raiser_StringValueChanged(object sender, EventArgs e)
        {
        }

        public MemoryLeak(EventRaiser raiser)
        {
            this._raiser = raiser;
            _allocatedMemory = new byte[10000];
            raiser.StringValueChanged += raiser_StringValueChanged;
        }
        //Fix the memory leak
        public void Dispose()
        {
            this._raiser.StringValueChanged -= this.raiser_StringValueChanged;
        }
    }
}