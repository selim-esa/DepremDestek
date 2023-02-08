using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string City { get; set; }

        public string District { get; set; }
     
        public string? Need { get; set; }
        public string? Adress { get; set; }

    }
}
