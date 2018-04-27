using Newtonsoft.Json;
using ExamenVueling.Common.Logic;
using ExamenVueling.DataAcces.Dao.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.DataAcces.Dao.Redis
{
    public class RedisDao
    {
        private readonly IDatabase _redis;

        public RedisDao()
        {
            _redis = RedisConfig.RedisCache;
        }

        public User Get()
        {
            var key = ConfigurationTools.GetRedisKey();
            return JsonConvert.DeserializeObject<User>(this._redis.StringGet(key));
        }

        public User Set(User user)
        {
            var key = ConfigurationTools.GetRedisKey();
            _redis.StringSet(key, JsonConvert.SerializeObject(user));
            return Get();
        }
    }
}
