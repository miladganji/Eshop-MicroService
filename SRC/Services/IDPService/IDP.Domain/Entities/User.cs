using IDP.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Domain.Entities
{
    public class User:BaseEntity
    {
        public required string  Fullname { get; set; }
        public required string  NationalCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
