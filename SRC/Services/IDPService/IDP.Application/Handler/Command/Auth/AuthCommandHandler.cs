﻿using AutoMapper;
using IDP.Application.Command.User;
using IDP.Domain.IRepository.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Handler.Command.Auth
{
    public class AuthCommandHandler : IRequestHandler<AuthCommand, bool>
    {
        //private readonly IOtpCommandRepository _otpRedisRepository;
        //private readonly IUserCommandRepository _userCommandRepository;
        //private readonly IUserQueryRepository _userQueryRepository;
        //private readonly IMapper _mapper;
        ////private readonly ICapPublisher _capBus;
        //private readonly IPublishEndpoint _publishEndpoint;
        //public AuthCommandHandler(IOtpRedisRepository otpRedisRepository,
        //    IUserCommandRepository userCommandRepository,
        //    IPublishEndpoint publishEndpoint,
        //    IUserQueryRepository userQueryRepository, IMapper mapper)
        //{
        //    _otpRedisRepository = otpRedisRepository;
        //    _userCommandRepository = userCommandRepository;
        //    _userQueryRepository = userQueryRepository;
        //    _mapper = mapper;
        //    _publishEndpoint = publishEndpoint;
        //    //_capBus = capPublisher;
        //}
        //public async Task<bool> Handle(AuthCommand request, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        var userobj = _mapper.Map<IDP.Domain.Entites.User>(request);
        //        var user = await _userQueryRepository.GetUserAsync(request.MobileNumber);
        //        if (user == null)
        //        {
        //            Random random = new Random();
        //            var code = random.Next(1000, 10000);
        //            //ارسال پیامک به سرویس نوتفیکیشن
        //            //await _capBus.PublishAsync<AuthCommand>("otpevent", new AuthCommand
        //            //{
        //            //    MobileNumber = request.MobileNumber,
        //            //});
        //            await _publishEndpoint.Publish<OtpEvents>(new OtpEvents
        //            {

        //                MobileNumber = request.MobileNumber,
        //                OtpCode = code.ToString(),
        //            });

        //            userobj.UserName = request.MobileNumber;
        //            var res = await _userCommandRepository.Insert(userobj);
        //            await _otpRedisRepository.Insert(new Domain.DTO.Otp { UserName = userobj.MobileNumber, OtpCode = code, IsUse = false });
        //        }
        //        else
        //        {
        //            Random random = new Random();
        //            var code = random.Next(1000, 10000);
        //            //ارسال پیامک به سزویس نوتفیکیشن
        //            //await _capBus.PublishAsync<AuthCommand>("otpevent", new AuthCommand
        //            //{
        //            //    MobileNumber = request.MobileNumber,
        //            //});
        //            await _publishEndpoint.Publish<OtpEvents>(new OtpEvents
        //            {

        //                MobileNumber = request.MobileNumber,
        //                OtpCode = code.ToString(),
        //            });
        //            userobj.UserName = request.MobileNumber;
        //            await _otpRedisRepository.Insert(new Domain.DTO.Otp { UserName = user.MobileNumber, OtpCode = code, IsUse = false });
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //}
        public Task<bool> Handle(AuthCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

