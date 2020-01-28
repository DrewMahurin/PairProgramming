using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedPrograming
{
    class PairedProgramming
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Cody", "Hunt");
            Student s2 = new Student("Roger", "Rabbit");
            Student s3 = new Student("Drew", "Mahurin");
            Student s4 = new Student("Lucas", "DeMamp");
            Student s5 = new Student("Shawnathon", "Snyder");
            Student s6 = new Student("Hannah", "Jamie");

            List<Student> student = new List<Student>() {
                s1, s2, s3, s4, s5, s6
            };

            Random rand = new Random();
            int index = rand.Next(0,student.Count-1);
            //student.RemoveAt(index);
            //MessageBox.Show(student[index].ToString());
            
            //System.Threading.Thread.Sleep(2);

            Console.WriteLine($"{index}");
            student.Remove(student[index]);
            index = rand.Next(0, student.Count - 1);
            Console.WriteLine($"{index}\n");

            Console.WriteLine($"{index}");
            student.Remove(student[index]);
            index = rand.Next(0, student.Count - 1);
            Console.WriteLine($"{index}\n");




        }
    }
}
