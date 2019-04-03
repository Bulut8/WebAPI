using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIProject.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int ID { get; set; }

        [StringLength(30),Column(TypeName ="Varchar")]
        public string Name { get; set; }

        [StringLength(30), Column(TypeName = "Varchar")]
        public string Surname { get; set; }

        public int Salary { get; set; }

        [StringLength(50), Column(TypeName = "Varchar")]
        public string Department { get; set; }
    }
}