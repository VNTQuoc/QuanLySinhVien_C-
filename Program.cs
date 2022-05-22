using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentList = new Student[5];
            Console.Write("How many student ?: ");
            int length = int.Parse(Console.ReadLine());
            studentList = new Student[length];
            int index = 0;

        Menu:
            Console.Clear();
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. List of stdent");
            Console.WriteLine("3. Search by Id");
            Console.WriteLine("4. Delete by Id");
            Console.WriteLine("5. Exit");
            Console.Write("Please chose one option: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    Student s = new Student();
                    Console.Write("Full Name: ");
                    string name = Console.ReadLine();
                    s.SetName(name);
                    Console.Write("Address: ");
                    string address = Console.ReadLine();
                    s.SetAddress(address);
                    DateTime birthday = DateTime.Now;
                NhapBirthDay:
                    Console.Write("Day of birth: ");
                    try
                    {
                        birthday = DateTime.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Wrong format!!");
                        Console.ReadLine();
                        goto NhapBirthDay;
                    }
                    s.SetBirthday(birthday);
                    s.SetID(index + 1);
                    studentList[index] = s;
                    index++;
                    goto Menu;
                case "2":
                    Console.WriteLine("The list\n---------------------\n");
                    foreach (Student s1 in studentList)
                    {
                        if (s1 != null)
                        {
                            s1.Display();
                        }
                    }
                    Console.ReadLine();
                    goto Menu;
                case "3":
                    Console.WriteLine("Plese type the Id for searching: ");
                    string tk = Console.ReadLine();
                    foreach (Student s2 in studentList)
                    {
                        if (s2 == null)
                        {
                            Console.WriteLine("Not found!");
                        }
                        else
                        {
                            s2.Display();
                        }
                    }
                    Console.ReadLine();
                    goto Menu;
                case "4":
                    goto Menu;
                case "5":
                    break;
                default:
                    Console.WriteLine("Please type again!(1 -> 5): ");
                    Console.ReadLine();
                    goto Menu;

            }
        }
    }

    public class Student
    {
        int id;
        string name;
        string address;
        DateTime birthDay;

        public void SetID(int id)
        {
            this.id = id;
        }

        public int GetID()
        {
            return this.id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAddress(string add)
        {
            address = add;
        }
        public void SetBirthday(DateTime birthday)
        {
            this.birthDay = birthDay;
        }

        public void Display()
        {
            Console.WriteLine("Student ID: {0}", id);
            Console.WriteLine("Studdent Name: {0}", name);
            Console.WriteLine("Studnent Address: {0}", address);
            Console.WriteLine("\n--------------------------\n");
        }

    }
}
