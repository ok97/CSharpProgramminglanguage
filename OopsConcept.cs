/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    public class Employee
    {


        public String Name = "Omprakash";
        public void Company()
        {
            Console.WriteLine("Compny Name Bridgelabz Solution");
        }
    }
    public class Sallery : Employee
    {
        public int Sall = 1000;
        public void Work()
        {
            Console.WriteLine("Working on Software Developer");
        }
    }
    public class PartTime : Employee
    {

        public void Work()
        {
            Console.WriteLine("Employee is Fulltime");
        }
    }


    class OopsConcept
    {
        public static void Main(String[] args)
        {
            //PartTime obj = new PartTime();
            //obj.Work();
            //Console.WriteLine();
            //obj.Work();
            //Console.WriteLine();

            Employee emp = new Employee();
            emp.Company();
            Sallery sal = new Sallery();
            sal.Work();
            PartTime part = new PartTime();
            part.Work();


            Console.WriteLine(emp.Name + " " + sal.Sall);

        }

    }
}*/
