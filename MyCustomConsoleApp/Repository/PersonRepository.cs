using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyCustomConsoleApp.Model;

namespace MyCustomConsoleApp.Repository
{
    public class PersonRepository
    {
        public Person Add(Person person)
        {
            DatabaseContext dbContext = new DatabaseContext();
            dbContext.Persons.Add(person);
            dbContext.SaveChanges();
            return person;
        }

        public List<Person> GetAll()
        {
            var databaseContext = new DatabaseContext();
            return databaseContext.Persons.ToList();
        }

        public Person GetById(int personId)
        {
            var databaseContext = new DatabaseContext();
            return databaseContext.Persons.SingleOrDefault(p => p.Id == personId);
        }
    }
}
