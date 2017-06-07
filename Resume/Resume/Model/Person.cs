using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Model
{
    public class Person
    {
        public string FistName { get; set; }
        [Required()]
        public string LastName { get; set; }
        [Required()]
        public string Phone { get; set; }
        [Required()]
        [DataType(DataType.PhoneNumber)]
        public string EmailAddress { get; set; }
        [Required()]
        [DataType(DataType.EmailAddress)]
        public string Address { get; set; }

    }
}
