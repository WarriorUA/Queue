using System;
using System.IO;
using System.Linq;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue head = new Queue();
            Queue last = new Queue();
            double a = double.Parse(Console.ReadLine());
            var streamReader = new StreamReader("TextFile.txt");
            int count = 0;
            while (!streamReader.EndOfStream)
            {
                string tmp = streamReader.ReadLine();
                double value = double.Parse(tmp);
                if (count == 0)
                {
                    head.value = value;
                    head.next = last;
                    count++;
                }
                else
                {
                    last.value = value;
                    last.next = new Queue();
                    last = last.next;
                    count++;
                }
            }
            Queue current = head;
            for (int i = 0; i < count; ++i)
            {
                if (current.value < a)
                {
                    Console.Write("{0} ",current.value);
                }
                current = current.next;
            }
            Console.WriteLine();
            current = head;
            for (int i = 0; i < count; ++i)
            {
                if (current.value >= a)
                {
                    Console.Write("{0} ", current.value);
                }
                current = current.next;
            }
            Console.ReadKey();
        }
    }

    class Queue
    {
        public double value { get; set; }
        public Queue next { get; set; }
    }
}
