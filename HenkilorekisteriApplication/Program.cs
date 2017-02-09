using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkilorekisteriApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a few Person objects

            Person person1 = new Person
            {
                Firstname = "Kirsi",
                Lastname = "Vainio",
                SocialSecurityNumber = "090909-233F"
            };

            Person person2 = new Person
            {
                Firstname = "Iina",
                Lastname = "Vainio",
                SocialSecurityNumber = "090789-253D"
            };

            Person person3 = new Person
            {
                Firstname = "Teppo",
                Lastname = "Vainio",
                SocialSecurityNumber = "090989-243B"
            };

            // create a Persons object
            Persons kamu = new Persons();

            // add person objects to persons collection
            kamu.AddPerson(person1);
            kamu.AddPerson(person2);
            kamu.AddPerson(person3);

            // get one person from persons collections
            Person person4 = kamu.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }else
            {
                Console.WriteLine("Person not found in that index!!!!");
            }

            // print collection
           kamu.PrintCollection();

            // find person
            string sotu = "090789-253B";
            Console.WriteLine("Find sotu : " + sotu);
            Person person5 = kamu.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }else
            {
                Console.WriteLine("Cant find person with that sotu..");
            }
        }
    }
}
