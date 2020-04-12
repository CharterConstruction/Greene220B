using System;
using System.Collections.Generic;
using HelloWorld.Models;
using System.Linq;


namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();

            users.Add(new User { Name = "Dave", Password = "hello" });
            users.Add(new User { Name = "Steve", Password = "steve" });
            users.Add(new User { Name = "Lisa", Password = "hello" });




            //var remainingUsers = users.Select(t => $"Name: {t.Name}, Password {t.Password}");            
            //string.Join(Environment.NewLine, remainingUsers);


            // Display users with password == "hello"
            WriteUsersWithPasswordHello(users);

            // Remove users where password == user's name
            users.RemoveAll(t => t.Password == t.Name.ToLower());

            // Delete the first user w/ password hello
            users.Remove(users.FindAll(t => t.Password == "hello").FirstOrDefault());

            // Display remaining users
            WriteUsersToConsole(users);


          

        }

        public static void WriteUsersWithPasswordHello(List<User> listOfUsers)
        {
            var results = from u in listOfUsers
                          where u.Password == "hello"
                          select u.Name;

            string outputString = "The Following Users Have 'hello' as Their Password:" + Environment.NewLine;
            outputString += "=======================================================" + Environment.NewLine;
            outputString += string.Join(Environment.NewLine, results);

            Console.WriteLine(outputString);

        }


        public static void WriteUsersToConsole(List<User> listOfUsers)
        {
            var userNames = listOfUsers.Select(t => $"Name: {t.Name}, Password: {t.Password}");



            string outputString = Environment.NewLine + "Current Users" + Environment.NewLine;
            outputString += "=======================================================" + Environment.NewLine;
            outputString += string.Join(Environment.NewLine, userNames) + Environment.NewLine;
            outputString += "=======================================================" + Environment.NewLine;

            Console.WriteLine(outputString);
        }











    }




}
