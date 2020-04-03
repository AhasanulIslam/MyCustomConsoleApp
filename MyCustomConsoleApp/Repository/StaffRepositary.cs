using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyCustomConsoleApp.Model;

namespace MyCustomConsoleApp.Repository
{
    class StaffRepositary
    {
          public Staff Add(Staff staff)
          {
            DatabaseContext dbContext = new DatabaseContext();
            dbContext.Staffs.Add(staff);
            dbContext.SaveChanges();
            return staff;
        }

          public List<Staff> GetAll()
          {
              var databaseContext = new DatabaseContext();
              return databaseContext.Staffs.ToList();
          }
          public Staff GetById(int staffId)
          {
              var databaseContext = new DatabaseContext();
              return databaseContext.Staffs.SingleOrDefault(p => p.Id == staffId);
          }
    }
}
