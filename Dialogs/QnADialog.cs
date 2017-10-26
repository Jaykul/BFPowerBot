using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;

namespace PowerBot.Dialogs
{
    [Serializable]
    public class QnADialog : Microsoft.Bot.Builder.CognitiveServices.QnAMaker.QnAMakerDialog
    {
        // Go to https://qnamaker.ai and feed data, train & publish your QnA Knowledgebase.
        public QnADialog(QnAMakerAttribute options) : base(new QnAMakerService(options))
        {
        }
    }
}
