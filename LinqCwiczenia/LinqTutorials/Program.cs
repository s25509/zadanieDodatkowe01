using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing
            var collection1 = LinqTasks.Task1();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task1:");
            foreach (var employee in collection1)
            {
                Console.WriteLine(employee.Ename + " " + employee.Job);
            }
            
            var collection2 = LinqTasks.Task2();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task2:");
            foreach (var employee in collection2)
            {
                Console.WriteLine(employee.Ename + " " + employee.Job + " " + employee.Salary);
            }
            
            var result3 = LinqTasks.Task3();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task3:");
            Console.WriteLine(result3);
            
            var collection4 = LinqTasks.Task4();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task4:");
            foreach (var employee in collection4)
            {
                Console.WriteLine(employee.Ename + " " + employee.Salary);
            }
            
            var collection5 = LinqTasks.Task5();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task5:");
            foreach (var employee in collection5)
            {
                Console.WriteLine(employee);
            }
            
            var collection6 = LinqTasks.Task6();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task6:");
            foreach (var employee in collection6)
            {
                Console.WriteLine(employee);
            }
            
            var collection7 = LinqTasks.Task7();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task7:");
            foreach (var job in collection7)
            {
                Console.WriteLine(job);
            }
            
            var result8 = LinqTasks.Task8();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task8:");
            Console.WriteLine(result8);
            
            var result9 = LinqTasks.Task9();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task9:");
            Console.WriteLine(result9);
            
            var collection10 = LinqTasks.Task10();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task10:");
            foreach (var employee in (dynamic)collection10)
            {
                Console.WriteLine(employee.Ename + " " + employee.Job + " " + employee.HireDate);
            }
            
            var collection11 = LinqTasks.Task11();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task11:");
            foreach (var department in collection11)
            {
                Console.WriteLine(department);
            }
            
            var collection12 = LinqTasks.Task12();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task12:");
            foreach (var employee in collection12)
            {
                Console.WriteLine(employee);
            }
            
            var result13 = LinqTasks.Task13(new [] {1,1,1,1,1,1,10,1,1,1,1});
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task13:");
            Console.WriteLine(result13);
            
            var collection14 = LinqTasks.Task14();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task14:");
            foreach (var department in collection14)
            {
                Console.WriteLine(department.Dname);
            }
            
            var collection15 = LinqTasks.Task15();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task15:");
            foreach (var job in collection15)
            {
                Console.WriteLine(job);
            }
            
            var collection16 = LinqTasks.Task16();
            Console.WriteLine();
            Console.WriteLine(" - - - - -");
            Console.WriteLine("Task16:");
            foreach (var taskforce in (dynamic)collection16)
            {
                Console.WriteLine(taskforce.emp.Ename + " " + taskforce.dept.Dname);
            }
        }
    }
}
