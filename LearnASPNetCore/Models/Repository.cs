using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnASPNetCore.Models
{
    public static class Repository
    {
        private static List<Person> people = new List<Person>();

        public static IEnumerable<Person> People
        {
            get { return people; }            
        }

        public static void AddPerson(Person person)
        {
            people.Add(person);
        }
    }
}
