using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MyCustomConsoleApp.Model;
using MyCustomConsoleApp.Repository;

namespace MyCustomConsoleApp.Controller
{
    public class PersonController: Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpPost("api/person/add")]
        public IActionResult AddPerson([FromBody] Person person)
        {
            PersonRepository personRepository = new PersonRepository();
            var p = personRepository.Add(person);
            return Ok(p);
        }

        [HttpGet("api/person/getAll")]
        public IActionResult GetAllPersons()
        {
            PersonRepository personRepository = new PersonRepository();
            return Ok(personRepository.GetAll());
        }

        [HttpGet("api/person/getById")]
        public IActionResult GetPersonById(int personId)
        {
            PersonRepository personRepository = new PersonRepository();
            return Ok(personRepository.GetById(personId));
        }
    }
}
