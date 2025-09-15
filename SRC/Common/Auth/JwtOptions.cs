using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
        public class JwtOptions
        {
            public string SecretKey { get; set; }
            public int ExpireMiniut { get; set; }
            public string Issue { get; set; }
        }
}
