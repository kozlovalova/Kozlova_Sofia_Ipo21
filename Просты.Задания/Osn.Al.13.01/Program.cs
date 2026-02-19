using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osn.Al._13._01
{
    class Student
    {
        public string name = "";
      
        public void Print()
        {
            Console.WriteLine($"Имя:{name}");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.name = "Fish";
            p1.Print();

            Student p2 = new Student();
            p2.name = "Slava";
            p2.Print();

            Student p3 = new Student();
            p3.name = "Polina";
            p3.Print();

            Student p4 = new Student();
            p4.name = "Sofia";
            p4.Print();

            Student p5 = new Student();
            p5.name = "Fisa";
            p5.Print();

        }
    }
}
