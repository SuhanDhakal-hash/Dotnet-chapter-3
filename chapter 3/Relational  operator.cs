using System;
namespace chapter_3
{
    class Student
    {
        public int marks1;
        public int marks2;

        public Student(int m1, int m2)
        {
            marks1 = m1;
            marks2 = m2;
        }
    }

    class Relationaloperator
    {
        static void Main(string[] args)
        {
            Student s = new Student(100, 50);

            Console.WriteLine("Marks1 = " + s.marks1);
            Console.WriteLine("Marks2 = " + s.marks2);

            
            Console.WriteLine("marks1 > marks2 : " + (s.marks1 > s.marks2));
            Console.WriteLine("marks1 < marks2 : " + (s.marks1 < s.marks2));
            Console.WriteLine("marks1 == marks2 : " + (s.marks1 == s.marks2));
            Console.WriteLine("marks1 != marks2 : " + (s.marks1 != s.marks2));
            Console.WriteLine("marks1 >= marks2 : " + (s.marks1 >= s.marks2));
            Console.WriteLine("marks1 <= marks2 : " + (s.marks1 <= s.marks2));

            
        }
    }
}