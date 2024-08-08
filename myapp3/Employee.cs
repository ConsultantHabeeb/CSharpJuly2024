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


        public void TestStringArray()
        {
            string [] days = new string [] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday"};

            foreach(string x in days)
            {
                Console.WriteLine(x);
            }
       
        }

        public void TestArray()
        {
            int [] marks = new int[6];
            marks[0] = 50;
            marks[1] = 30;//Failed
            marks[2] = 70;
            marks[3] = 17;
            marks[4] = 90;
            marks[5] = 76;
           // marks[6] = 89;
           //Number of passed candidates: 5
           //Number of failed candidates: 1
          
          int passedcandidates = 0, failedcandidates=0;

            /*
                foreach(mark in marks) //for collections
                {
                 if(mark >=35)

                }
            */
          for(int i=0; i<marks.Length; i++)
           {
             
             if (marks[i]>=35)
             {
                    passedcandidates++; //passedcandidates = passedcandidates +1;
             }
             else
             {
                failedcandidates += 1;
            
             }
           }
            Console.WriteLine("Number of passed candidates:" + passedcandidates);
            Console.WriteLine("Number of failed candidates:" + failedcandidates);
        }

        public  void Test1()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, Test!");
        }


    
    }



}