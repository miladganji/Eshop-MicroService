using IDP.Domain.Dto;
using IDP.Domain.IRepository.Command;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Infra.Repository.Command
{
    public class OtpCommandRepository : IOtpCommandRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IDistributedCache _distributedCache;

        public OtpCommandRepository(IConfiguration configuration,IDistributedCache distributedCache)
        {
            this._configuration = configuration;
            this._distributedCache = distributedCache;
        }
        public async Task<bool> Delete(Otp entity)
        {
         await   _distributedCache.RemoveAsync(entity.UserId.ToString());
            return true;
        }

        public Task<bool> Insert(Otp entity)
        {
            int time = Convert.ToInt32(_configuration.GetSection("Otp:OtpTime").Value);
            _distributedCache.SetString(entity.UserId.ToString(), JsonConvert.SerializeObject(entity), new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(time)).SetAbsoluteExpiration(TimeSpan.FromMinutes(time)));

            return null;
        }

        public async Task<Otp> Getdata(string mobile)
        {
            var data = _distributedCache.GetString(mobile);
            if (data == null) return null;
            var otpobj = JsonConvert.DeserializeObject<Otp>(data);
            return otpobj;
        }


        public Task<bool> Update(Otp entity)
        {
            throw new NotImplementedException();
        }
    }
}
