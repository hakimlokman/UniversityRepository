using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityRepository.BusinessLayer;
using UniversityRepository.DataAccessLayer;

namespace UniversityRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University(new StudentRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Student> _listCustomer = university.Get();
                        Console.WriteLine("List of Customer:");
                        Console.WriteLine("Roll   |   Name    |   Subject");
                        foreach (Student _customer in _listCustomer)
                        {
                            Console.WriteLine(_customer.Roll + "  |   " + _customer.Name + "  |   " + _customer.Subject);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a Roll to find a Student:");
                        string roll = Console.ReadLine();
                        Student aCstomer = university.Get(Convert.ToInt32(roll));
                        Console.WriteLine(aCstomer.Roll + ". " + aCstomer.Name + " -- " + aCstomer.Subject);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a Roll:");
                        string roll = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a Subject:");
                        string subject = Console.ReadLine();
                        Student Universities = new Student();
                        Universities.Roll = Convert.ToInt32(roll);
                        Universities.Name = name;
                        Universities.Subject = subject;
                        bool isExecuted = university.Add(Universities);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a Roll:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a Subject:");
                        string subject = Console.ReadLine();
                        Student Universities = new Student();
                        Universities.Roll = Convert.ToInt32(id);
                        Universities.Name = name;
                        Universities.Subject = subject;
                        bool isExecuted = university.Update(Universities);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a Roll:");
                        string roll = Console.ReadLine();
                        bool isExecuted = university.Delete(Convert.ToInt32(roll));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }
    }
}
