using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace MyCustomConsoleApp.Controllers
{
    public class CommandController : Microsoft.AspNetCore.Mvc.Controller
    {

    
        [HttpGet("api/command/getString")]
        public IActionResult GetString(int x, int y)
        {
            var user = new User();
            user.Id = x;
            user.Name = y;
            return Ok(user);
             
    
        }
    }
    
    class User
    {
        public int Id;
        public int Name;
        

       
    }
}

