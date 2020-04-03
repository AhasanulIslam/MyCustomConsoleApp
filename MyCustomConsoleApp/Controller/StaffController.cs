using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MyCustomConsoleApp.Model;
using MyCustomConsoleApp.Repository;

namespace MyCustomConsoleApp.Controller
{
    class StaffController: Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpPost("api/staff/add")]
        public IActionResult AddStaff([FromBody] Staff staff)
        {
            StaffRepositary personRepository = new StaffRepositary();
            var p = personRepository.Add(staff);
            return Ok(p);
        }

        [HttpGet("api/staff/getAll")]
        public IActionResult GetAllPersons()
        {
            StaffRepositary staffRepository = new StaffRepositary();
            staffRepository = new StaffRepositary();
            return Ok(staffRepository.GetAll());
        }

        [HttpGet("api/staff/getById")]
        public IActionResult GetPersonById(int staffId)
        {
            StaffRepositary staffRepository = new StaffRepositary();
            return Ok(staffRepository.GetById(staffId));
        }
    }
}
