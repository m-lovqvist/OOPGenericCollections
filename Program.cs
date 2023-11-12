using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace Labb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee()
            {
                ID = 120,
                Name = "Malin",
                Gender = "Female",
                Salary = 30000
            };
            Employee E2 = new Employee()
            {
                ID = 121,
                Name = "Erik",
                Gender = "Male",
                Salary = 35000
            };
            Employee E3 = new Employee()
            {
                ID = 122,
                Name = "Vilgot",
                Gender = "Male",
                Salary = 40000
            };
            Employee E4 = new Employee()
            {
                ID = 123,
                Name = "Anna",
                Gender = "Female",
                Salary = 25000
            };
            Employee E5 = new Employee()
            {
                ID = 124,
                Name = "Anders",
                Gender = "Male",
                Salary = 40000,

            };
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Items left in the Stack = " + stack.Count());

            foreach (Employee emp in stack)
            {
                Console.WriteLine($"{emp.ID} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                Console.WriteLine("Items left in the Stack = " + stack.Count());
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrieve using Pop Method");

            Employee stackEmp = stack.Pop();
            Console.WriteLine($"{stackEmp.ID} - {stackEmp.Name} - {stackEmp.Gender} - {stackEmp.Salary}");
            Console.WriteLine("Items left in the Stack = " + stack.Count());
            Employee stackEmp2 = stack.Pop();
            Console.WriteLine($"{stackEmp2.ID} - {stackEmp2.Name} - {stackEmp2.Gender} - {stackEmp2.Salary}");
            Console.WriteLine("Items left in the Stack = " + stack.Count());
            Employee stackEmp3 = stack.Pop();
            Console.WriteLine($"{stackEmp3.ID} - {stackEmp3.Name} - {stackEmp3.Gender} - {stackEmp3.Salary}");
            Console.WriteLine("Items left in the Stack = " + stack.Count());
            Employee stackEmp4 = stack.Pop();
            Console.WriteLine($"{stackEmp4.ID} - {stackEmp4.Name} - {stackEmp4.Gender} - {stackEmp4.Salary}");
            Console.WriteLine("Items left in the Stack = " + stack.Count());
            Employee stackEmp5 = stack.Pop();
            Console.WriteLine($"{stackEmp5.ID} - {stackEmp5.Name} - {stackEmp5.Gender} - {stackEmp5.Salary}");
            Console.WriteLine("Items left in the Stack = " + stack.Count());
            Console.WriteLine("----------------------------");

            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            Console.WriteLine("Retrieve using Peek Method");
            Employee emp1 = stack.Peek();
            Console.WriteLine($"{emp1.ID} - {emp1.Name} - {emp1.Gender} - {emp1.Salary}");
            Console.WriteLine("Items left in the Stack = " + stack.Count());
            Employee emp2 = stack.Peek();
            Console.WriteLine($"{emp2.ID} - {emp2.Name} - {emp2.Gender} - {emp2.Salary}");
            Console.WriteLine("Items left in the Stack = " + stack.Count());
            Console.WriteLine("----------------------------");

            if (stack.Contains(E3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Object is not in the Stack");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            var Emp1 = new Employee();
            Emp1.ID = 120;
            Emp1.Name = "Malin";
            Emp1.Gender = "Female";
            Emp1.Salary = 30000;

            var Emp2 = new Employee();
            Emp2.ID = 121;
            Emp2.Name = "Erik";
            Emp2.Gender = "Male";
            Emp2.Salary = 35000;

            var Emp3 = new Employee();
            Emp3.ID = 122;
            Emp3.Name = "Vilgot";
            Emp3.Gender = "Male";
            Emp3.Salary = 40000;

            var Emp4 = new Employee();
            Emp4.ID = 123;
            Emp4.Name = "Anna";
            Emp4.Gender = "Female";
            Emp4.Salary = 25000;

            var Emp5 = new Employee();
            Emp5.ID = 124;
            Emp5.Name = "Anders";
            Emp5.Gender = "Male";
            Emp5.Salary = 40000;

            var employeeList = new List<Employee>() { Emp1, Emp2, Emp3, Emp4, Emp5 };

            if (employeeList.Contains(Emp2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }
            Console.WriteLine();

            Employee employee = employeeList.Find(x => x.Gender == "Male");

            Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            Console.WriteLine();

            var result = employeeList.FindAll(x => x.Gender == "Male");

            foreach (var item in result ) 
            {
                Console.WriteLine($"ID = {item.ID}, Name = {item.Name}, Gender = {item.Gender}, Salary = {item.Salary}");
            }
            Console.ResetColor();


        }
    }
}