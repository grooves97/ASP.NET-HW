using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.DTOs;

namespace WebApplication10.Services
{
    public class EntitySaverService : IEntitySaverServices
    {
        public Task SaveEntity(EntityDTO entity)
        {
            var jsonResult = JsonConvert.SerializeObject(entity);
            return System.IO.File.WriteAllTextAsync("1.json", jsonResult);
        }
    }
}
