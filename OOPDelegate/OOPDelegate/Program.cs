using System;
using System.Collections.Generic;

public delegate void HelloFunctionDelegate(string Message);
public delegate bool IsPormotable(Employee emp1);

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void Promot(List<Employee> employeeList, IsPormotable IsEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("hello");

        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { ID = 1, Name = "abood", Salary = 1000, Experience = 8 });
        empList.Add(new Employee() { ID = 1, Name = "z", Salary = 322, Experience = 7 });
        empList.Add(new Employee() { ID = 1, Name = "w", Salary = 432, Experience = 2 });
        empList.Add(new Employee() { ID = 1, Name = "s", Salary = 533, Experience = 4 });

        IsPormotable pro = new IsPormotable(Promote2);
        Employee.Promot(empList, pro);
    }

    public static bool Promote2(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}