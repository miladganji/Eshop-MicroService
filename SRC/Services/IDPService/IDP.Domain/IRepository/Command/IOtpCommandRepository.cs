using IDP.Domain.Dto;
using IDP.Domain.IRepository.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Domain.IRepository.Command
{
    public interface IOtpCommandRepository:ICommandRepository<Otp>
    {
        Task<Otp> Getdata(string mobile);
    }
}
