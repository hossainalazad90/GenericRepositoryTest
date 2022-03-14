using GenericRepositoryTest.Models.AuditableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.Models
{
    public class Employee:AuditableEntity<int>
    {
        public override int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ContactNo { get; set; }


    }
}
