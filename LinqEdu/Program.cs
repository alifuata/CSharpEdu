using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEdu
{
    class Program
    {
        static void Main(string[] args)
        {
            //source=https://www.csharp-examples.net/linq-aggregation-methods/
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){age=41,companyName="Hacettepe",name="Ali"},
                new Employee(){age=38,companyName="Hacettepe",name="Veli"},
                new Employee(){age=22,companyName="Hacettepe",name="Ayse"},
                new Employee(){age=27,companyName="Gazi",name="Hatice"},
                new Employee(){age=19,companyName="Gazi",name="Meral"},
                new Employee(){age=52,companyName="Ankara",name="Bilge"},
                new Employee(){age=36,companyName="Ankara",name="Gonca"},
                new Employee(){age=34,companyName="Ankara",name="Zeynep"}
            };
            Console.WriteLine("Sum all ages group by companyName;");
            var result = from emp in employees group emp by emp.companyName into empGroup select new { company = empGroup.Key, Totalage = empGroup.Sum(x => x.age) };
            foreach (var item in result)
            {
                Console.WriteLine(item.company + "\t" + item.Totalage);
            }
            Console.Write("Sum all ages of Hacettepe >30 :");
            int tot = (from x in employees where x.age > 30 && x.companyName == "Hacettepe" select x.age).Sum();
            Console.WriteLine(tot);

            Console.Write("Sum all ages of Ankara:");
            int tot2 = (from x in employees where x.companyName == "Ankara" select x.age).Sum();
            Console.WriteLine(tot2);

            Console.WriteLine("Max ages of all:");

            var result1 = from emp in employees group emp by emp.companyName into empGroup select new { company = empGroup.Key, Totalage = empGroup.Max(x => x.age) };
            foreach (var item in result1)
            {
                Console.WriteLine(item.company + "\t" + item.Totalage);
            }
            Console.Write("Max ages of haceppete:");
            int tot3 = (from x in employees where x.companyName == "Hacettepe" select x.age).Max();
            Console.WriteLine(tot3);

            Console.WriteLine("Average ages of all:");

            var result2 = from emp in employees group emp by emp.companyName into empGroup select new { company = empGroup.Key, Totalage = empGroup.Average(x => x.age) };
            foreach (var item in result2)
            {
                Console.WriteLine(item.company + "\t" + item.Totalage);
            }

            Console.Write("Average ages of ankara:");
            double tot4 = (from x in employees where x.companyName == "Ankara" select x.age).Average();
            Console.WriteLine(tot4);
        }
    }
    public class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public string companyName { get; set; }
    }
}
