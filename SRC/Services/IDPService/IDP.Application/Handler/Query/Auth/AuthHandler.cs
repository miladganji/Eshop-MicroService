using Auth;
using IDP.Application.Query.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Handler.Query.Auth
{
    public class AuthHandler : IRequestHandler<AuthQuery, JsonWebToken>
    {
        private readonly IjwtHamdler ijwtHamdler;

        public AuthHandler(IjwtHamdler ijwtHamdler)
        {
            this.ijwtHamdler = ijwtHamdler;
        }
        public async Task<JsonWebToken> Handle(AuthQuery request, CancellationToken cancellationToken)
        {
            var Token = ijwtHamdler.Create(1);
            return Token;
        }
    }
}
