using System;
using System.ComponentModel;
namespace MyProject
{
public class Swapping
{

    public static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, Swapping!");

        Employee obj = new Employee("John",1000,"Jeddah",1100.00f);
        
        Employee emp = new Employee("Abdul","Chennai");

        Employee emp2 = new Employee();

        emp.TestArray();

        emp.TestStringArray();


        Console.WriteLine(obj.Name);

        float sal = obj.CalculateSalary(23);

        Console.WriteLine("The salary for 23 days is :" + sal);
        //obj.Test();
    }


    static int val1 = 100, val2 =200;

    static int r = Add(in val1, in val2);
    public static int Add(in int a,in int b)
    {
     
        return a+b;
    }

}
}