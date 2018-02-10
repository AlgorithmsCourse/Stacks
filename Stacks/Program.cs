using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's build a stack of strings!");
            Console.WriteLine("Enter a stack you would like to build: FixedSize or ResizingArray");
            var type = Console.ReadLine().ToLower();
            if (type == "fixedsize")
            {
                Console.WriteLine("what size array?");
                var size = Console.ReadLine();
                var s = new Stack_FixedSize(Int32.Parse(size));

                var action = "start";
                while (action != "q")
                {
                    Console.WriteLine("To add a word type 'add' or to remove the top item from the stack type 'remove'");
                    action = Console.ReadLine();
                    if (action == "add")
                    {
                        Console.WriteLine("Enter a word to add to the stack");
                        var newWord = Console.ReadLine();
                        s.Push(newWord);
                        Console.WriteLine($"{newWord} was added to the stack. Your stack now has {s.Size()} items.");
                        
                    }
                    else if (action == "remove")
                    {
                        Console.WriteLine($"{s.Pop()} has been removed from the stack. Your stack now has {s.Size()} items.");
                    } 
                    else if (action == "q")
                    {
                        break;
                    }
                }


 
            }
            



        }
    }
}
