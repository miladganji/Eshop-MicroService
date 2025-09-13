using IDP.Application.Command.User;
using IDP.Domain.IRepository.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Handler.User
{
    public class UserHandler : IRequestHandler<UserCommand, bool>
    {
        private readonly IUserRepository userRepository;

        public UserHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<bool> Handle(UserCommand request, CancellationToken cancellationToken)
        {

            var res =await userRepository.Insert(new Domain.Entities.User() { Fullname =request.Name,NationalCode=request.NationalCode});
            return res;

        }
    }
}
