using System;
namespace laba_17b
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;
            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }
        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Environment.Exit(0);
        }
    }
    class Counter
    {
        private int threshold;
        private int total;
        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }
        public void Add(int x)
        {
            total += x; // тут має бути збільшення параметра циклу
                        /* ... */ // а тут – накопичення суми
            if (total >= threshold) // а тут - припинення обчислення суми
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }

 protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event EventHandler ThresholdReached;
    }
}