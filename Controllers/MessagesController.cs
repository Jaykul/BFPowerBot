using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PowerBot.Models;

namespace PowerBot.Controllers
{
    [Route("api/[controller]")]
    [BotAuthentication]
    public class MessagesController : Controller
    {
        private readonly LuisOptions _luisOptions;
        private readonly QnAOptions _qnaOptions;

        public MessagesController(IOptions<LuisOptions> luisOptions, IOptions<QnAOptions> qnaOptions)
        {
            _luisOptions = luisOptions.Value;
            _qnaOptions = qnaOptions.Value;
        }

        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity?.Type == ActivityTypes.Message)
            {
                await Conversation.SendAsync(activity, () => new Dialogs.QnADialog(_qnaOptions.GetModel()));
            }
            else
            {
                HandleSystemMessage(activity);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}