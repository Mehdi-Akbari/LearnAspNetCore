using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnASPNetCore.Models
{
    public class EFPersonRepository : IPersonRepository
    {

        public EFPersonRepository(MyDBContext ctx)
        {
            context = ctx;
        }

        MyDBContext context;
        public IQueryable<Person> People => context.People;
    }
}
