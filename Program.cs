using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kolejka = new Queue<string>();
            kolejka.Enqueue("Pierwszy");
            kolejka.Enqueue("Drugi");
            kolejka.Enqueue("Trzeci");

            Console.WriteLine("Pierwszy element kolejki: " + kolejka.Peek());
            Console.WriteLine(" ");

            foreach (var item in kolejka)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Nacisnij Enter aby usunac element z kolejki ");
            Console.ReadLine();
            kolejka.Dequeue();
            Console.WriteLine(" ");
            Console.WriteLine("Pierwszy element kolejki: " + kolejka.Peek());
            Console.WriteLine(" ");

            foreach (var item in kolejka)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Nacisnij Enter aby kontynulowac ze stosem");
            Console.ReadLine();

            Stack<string> stack = new Stack<string>();
            stack.Push("Pierwszy");
            stack.Push("Drugi");
            stack.Push("Trzeci");

            Console.WriteLine("Pierwszy element stosu: " + stack.Peek());
            Console.WriteLine(" ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Nacisnij Enter aby usunac element ze stosu");
            Console.ReadLine();
            stack.Peek();
            Console.WriteLine("Pierwszy element stosu: " + stack.Pop()); 
            Console.WriteLine(" ");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

