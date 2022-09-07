using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void HelloFunctionDelegate(string Message);
    class Program
    { 
        public static bool Promote(Employee emp)
        {
            if (emp.Experience>=5)
            {
                return true;
            }
            return false;
        }
        
        public void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        static void Main(string[] args)
        {
            //Delegate Introduction
            Program p = new Program();
            HelloFunctionDelegate del = new HelloFunctionDelegate(p.Hello);
            del("Akankshi");

            //Deletgate Usage
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            employees.Add(new Employee() { ID = 102, Name = "Maryam", Salary = 6000, Experience = 7 });
            employees.Add(new Employee() { ID = 103, Name = "Adam", Salary = 7000, Experience = 4 });

            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(employees,isPromotable);
            Console.ReadLine();
        }

    }
}
