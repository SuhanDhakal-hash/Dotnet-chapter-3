using chapter_3;
using System;

namespace chapter_3
{
    class StaticConstructor
    {
        public string name;


        public StaticConstructor()
        {
            this.name = "Three Body Problem";
            Console.WriteLine($"Book name: {this.name}");
        }
    }

    class Constructors
    {
        static void Main()
        {
            Book bookObj = new Book();
        }
    }
}