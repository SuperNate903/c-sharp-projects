using System;
using System.Data.Entity;
using System.Linq;

namespace FinalChallenge
{
    class Program
    {
        static void Main()
        {
            using(var db = new StudentDb()) {
                string answer = "";

                while(answer != "quit") {
                    Console.WriteLine("What would you like to do?\n\'Add\' a student\n\'Remove\' a student\n\'Check\' the Database\n\'Quit\'");
                    answer = Console.ReadLine().ToLower();

                    if(answer == "add")
                    {
                        Console.WriteLine("Please fill out the necessary information");
                        string fname = null;
                        string lname = null;

                        while(fname == null) {
                            Console.WriteLine("What is their first name?");
                            fname = Console.ReadLine();
                            if(fname == null) Console.WriteLine("Please enter a first name.");
                        }
                        while (lname == null)
                        {
                            Console.WriteLine("What is their last name?");
                            lname = Console.ReadLine();
                            if (lname == null) Console.WriteLine("Please enter a first name.");
                        }

                        var student = new Student {
                            FirstName = fname,
                            LastName = lname
                        };
                        db.Students.Add(student);
                        db.SaveChanges();

                        Console.WriteLine("{0} {1} has successfully been added to the database.", fname, lname);
                    }
                    else if (answer == "remove")
                    {
                        Console.WriteLine("Input their id number to remove them.");
                        
                        var students = (from s in db.Students
                                       orderby s.Id
                                       select s).ToList();

                        bool idChosen = false;

                        while (!idChosen) {
                            foreach (var student in students)
                            {
                                Console.WriteLine("{0}: {1} {2}", student.Id, student.FirstName, student.LastName);
                            }

                            int idInput = Convert.ToInt32(Console.ReadLine());

                            if(idInput > 0)
                            {
                                var student = db.Students.Find(idInput);
                                db.Students.Remove(student);
                                db.SaveChanges();
                                Console.WriteLine("{0} {1} has been removed from the database.", student.FirstName, student.LastName);
                                idChosen = true;
                            }
                        }
                    }
                    else if (answer == "check")
                    {
                        var students = (from s in db.Students
                                        orderby s.Id
                                        select s).ToList();

                        foreach (var student in students)
                        {
                            Console.WriteLine("{0}: {1} {2}", student.Id, student.FirstName, student.LastName);
                        }

                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                    }
                    else if (answer != "quit")
                    {
                        Console.WriteLine("Please type the keyword inside the single quotation marks.");
                    }
                }
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class StudentDb : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
