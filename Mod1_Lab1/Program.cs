//This Program displays details of a person.

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variables of different data types
            //initialize with a default value
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            //Assign some values
            firstName = "Pragathi";
            lastName = "Gajjala";
            age = 34;
            street = "10619 221st ln";
            city = "Redmond";
            country = "USA";
            birthDate = new DateTime(1984, 02, 23);

            //output to the console window
            
            Console.WriteLine("First Name:    "+firstName);
            Console.WriteLine("Last Name:     "+lastName);

            //use placeholder style
             Console.WriteLine("Age:           {0} years old", age);
           
            //use string concatenation
            Console.WriteLine("Adress:        "+street + "," + city + "," + country);

            //use string interpolation
            Console.WriteLine($"Date of Birth: {birthDate}");


        }
    }
}
