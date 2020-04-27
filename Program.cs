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
            Queue<string> li = new Queue<string>();
            li.Enqueue("Pierwszy");
            li.Enqueue("Drugi");
            li.Enqueue("Trzeci");

            Console.WriteLine("Pierwszy element kolejki: " + li.Peek());

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Nacisnij Enter aby usunac element z kolejki ");
            Console.ReadLine();
            li.Dequeue();
            Console.WriteLine("Pierwszy element kolejki: " + li.Peek());

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Nacisnij Enter aby kontynulowac ze stosem");
            Console.ReadLine();

            Stack<string> stack = new Stack<string>();
            stack.Push("Pierwszy");
            stack.Push("Drugi");
            stack.Push("Trzeci");

            Console.WriteLine("Pierwszy element stosu: " + stack.Peek());
            Console.WriteLine("Nacisnij Enter aby usunac element ze stosu");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            stack.Peek();
            Console.WriteLine("Pierwszy element stosu: " + stack.Pop());

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
