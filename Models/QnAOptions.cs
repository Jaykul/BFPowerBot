using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBot.Models
{
    public class QnAOptions
    {
        public string QnASubscriptionKey { get; set; }
        public string QnAKnowledgebaseId { get; set; }

        public QnAMakerAttribute GetModel() => new QnAMakerAttribute(
                                                        QnASubscriptionKey,
                                                        QnAKnowledgebaseId, 
                                                        defaultMessage: "I'm sorry, I don't know that one.", 
                                                        scoreThreshold: 0.5, 
                                                        top: 1);
    }
}
