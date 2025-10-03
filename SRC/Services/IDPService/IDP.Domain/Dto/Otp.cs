using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Domain.Dto
{
    public class Otp
    {
        public required Int64 UserId { get; set; }
        public required string  OtpCode { get; set; }
        public bool IsUsed { get; set; }
    }
}
