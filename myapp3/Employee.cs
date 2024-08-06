using System;
namespace MyProject
{
    public class Employee

    {


        public string Name;
        public int ID;

        public string City;

        public float SalaryPerDay;

    //Constructor
        public Employee(string name, int id, string city, float salaryPerDay)
        {
            Name = name;
            ID = id; 
            City = city;
            SalaryPerDay = salaryPerDay;
        }

        public Employee()
        {
            Name=String.Empty;
            ID=0;
            City="Riyadh";
            SalaryPerDay=1000.00f;

        }


        public  Employee(string name, string city)
            {
                Name = name;
                City = city;
                SalaryPerDay=1000.00f;
                ID=1001;
            }

        public float CalculateSalary(int days)
        {
            return SalaryPerDay * days;
        }

        public  void Test()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, Test!");
        }


    
    }

    public class Manager()



}