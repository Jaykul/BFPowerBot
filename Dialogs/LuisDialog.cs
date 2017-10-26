using System;
using System.Configuration;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Extensions.Options;

namespace PowerBot.Dialogs
{
    // For more information about this template visit http://aka.ms/azurebots-csharp-luis
    [Serializable]
    public class LuisDialog : LuisDialog<object>
    {
        public LuisDialog(ILuisModel model) : base(new LuisService(model))
        {
        }

        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("Get-Command")]
        public async Task GetCommand(IDialogContext context, LuisResult result)
        {
            EntityRecommendation command;
            result.TryFindEntity("CommandSynopsis", out command);
            await context.PostAsync($"Imagine I'm returning the results of calling: Get-Command {command.Entity}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("Get-Parameter")]
        public async Task GetParameter(IDialogContext context, LuisResult result)
        {
            EntityRecommendation command;
            result.TryFindEntity("CommandName", out command);
            await context.PostAsync($"Imagine I'm returning the results of calling: Get-Command {command.Entity} -Syntax"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("Get-Help")]
        public async Task MyIntent(IDialogContext context, LuisResult result)
        {
            EntityRecommendation command;
            result.TryFindEntity("CommandSynopsis", out command);
            await context.PostAsync($"Imagine I'm returning the results of calling: Get-Help {command.Entity} | % Synopsis"); //
            context.Wait(MessageReceived);
        }
    }
}