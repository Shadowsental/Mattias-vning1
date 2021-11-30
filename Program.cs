using System;
using System.Collections.Generic;

namespace MattiasÖvning1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            while(isOn == true)
            {
                //string[] employeeList = new string[] {  };
                List<string> employeeList = new List<string>() { "Employee name is Carl Aardvark and their pay is $39.99." };

                Console.WriteLine("Hello and welcome to Gordon Ramsay's Hangoveria. We employ the very best baristas in the country. We would like you to add them to our registry.");
                Console.Write("Would you like to add or would you like to see who is here? Type Add to add, Check to check the list or Exit to close down the application: ");
                string action = Console.ReadLine();

                if (action == "Add")
                {

                    Console.Write("What is the employee's name?: ");
                    string employeeName = Console.ReadLine();

                    Console.Write("What is their pay?: ");
                    string employeePay = Console.ReadLine();

                    string employee = $"Employee name is {employeeName} and their pay is {employeePay}.";
                    Console.WriteLine(employee);

                    employeeList.Add(employee);

                    Console.ReadLine();
                }

                else if (action == "Check")
                {
                    foreach (string names in employeeList)
                    {
                        Console.WriteLine(names);
                    }
                    Console.ReadLine();
                }

                else if (action == "Exit")
                {
                    isOn = false;
                }

                else
                {
                    Console.WriteLine("Sorry, that is noth what this registry can do.");
                    Console.ReadLine();
                }

            }
        }
    }
}
