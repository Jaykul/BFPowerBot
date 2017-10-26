using Microsoft.Bot.Builder.Luis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBot.Models
{
    public class LuisOptions 
    {
        public string LuisAppId { get; set; }
        public string LuisAPIKey { get; set; }

        public ILuisModel GetModel()
        {
            return new LuisModelAttribute(LuisAppId, LuisAPIKey);
        }
    }
}
