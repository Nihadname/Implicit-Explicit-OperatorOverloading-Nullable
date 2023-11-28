using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Explicit_OperatorOverloading_Nullable.Models
{
   public class Employee
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public DateTime BirthDay { get; set; }

        public Employee(string firstName,string lastName,int salary,DateTime birthday) { 
        FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            BirthDay = birthday;
        }
        public Employee()
        {
            
        }
        public  Employee[] Employees()
        {
            Employee employee1 = new("Nihad1","Ibadzade1",1280,new DateTime(2008,2,12));
            Employee employee2 = new("Nihad2", "Ibadzade2", 480, new DateTime(2002, 2, 12));
            Employee employee3 = new("Nihad3", "Ibadzade3", 9870, new DateTime(2003, 2, 12));
            Employee employee4 = new("Nihad4", "Ibadzade4", 990, new DateTime(2004, 2, 12));
            Employee employee5 = new("Nihad5", "Ibadzade5", 680, new DateTime(2006, 2, 12));
            Employee employee6 = new("Nihad6", "Ibadzade6", 3480, new DateTime(2004, 2, 12));
            Employee[] employees =  { employee1, employee2, employee3, employee4, employee5,employee6 };
            return employees;
        }

        public int ShowingHowManyEmployeesMeetRequirements(DateTime m,DateTime n,int salary)
        {
            Employee[] employeesOfArray = Employees();
            int count = 0;
foreach (Employee employee in employeesOfArray)
            {
                if (employee.BirthDay>=m && employee.BirthDay<=n && employee.Salary>salary)
                {
                    count++;
                }
            }
return count;
        }
    }
}
