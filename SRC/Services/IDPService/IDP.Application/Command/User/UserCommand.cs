using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Command.User
{
    public class UserCommand:IRequest<bool>
    {

        public string Name { get; set; }
    }
}
