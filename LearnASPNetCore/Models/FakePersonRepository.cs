using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnASPNetCore.Models
{
    public class FakePersonRepository : IPersonRepository
    {
        public IQueryable<Person> People => new List<Person>
        {
            new Person { Name ="Alireza",LastName ="Alavi"},
            new Person {Name="Mohammad", LastName="Mohammadi"}
        }.AsQueryable<Person>();
    }
}
