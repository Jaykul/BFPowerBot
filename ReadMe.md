# Bot Framework and Cognitive Services

## Before I forget, a bunch of useful links:

1. [Presenter Bot Video (5min)](https://channel9.msdn.com/Series/Explain/Meet-the-presenter-bot-a-bot-that-presents-about-bots?term=bot%20framework)
1. [Bot Framework Homepage](https://dev.botframework.com/)
1. [Bot Framework Documentation](https://docs.microsoft.com/en-us/bot-framework/)
1. [Getting Started - How It Works](https://docs.microsoft.com/en-us/bot-framework/overview-how-bot-framework-works)
1. [AzureLens Architecture](https://www.azurelens.net/?github=MicrosoftDX/AzureLens/master/AzureLens/SampleModels/Bots.json#navUsers)
1. [Bot Framework Emulator](https://emulator.botframework.com/)

## Now let's code.

### Design of an empty Bot Framework App

* See initial checkin [#488bfe6](https://github.com/VDUNY/2017-10/commit/488bfe64720a6a4070aeac62e446059000f6d7a6) on master.
* Run it
  * Connect the Emulator
  * Show Log and Details

There's a lot you can do here without any additional help.
And since our introducer mentioned rich interfaces, let's look at [Adaptive Cards](http://adaptivecards.io/).
They support images, speech, containers, columns, actions [and more](http://adaptivecards.io/explorer/).
They don't work perfectly everywhere, but [they work in many places](https://docs.microsoft.com/en-us/adaptive-cards/get-started/bots#channel-status)

* [Discuss Channels](https://docs.microsoft.com/en-us/bot-framework/portal-configure-channels)
* [Discuss Dialogs](https://docs.microsoft.com/en-us/bot-framework/dotnet/bot-builder-dotnet-dialogs)


## LUIS ([Luis.ai](https://www.luis.ai/))

* Free up to 10,000 transactions per month, then $0.75 per 1,000 transactions
* [LUIS Apps](https://www.luis.ai/applications)
* [Intents and Entities](https://docs.microsoft.com/en-us/bot-framework/dotnet/bot-builder-dotnet-luis-dialogs)


There are a lot of other lower-level services from Cognitive Services:

* The [Text Analytics API](https://www.microsoft.com/cognitive-services/en-us/text-analytics-api) detects sentiment, key phrases, topics, and language from text.
* The [Bing Spell Check API](https://www.microsoft.com/cognitive-services/en-us/bing-spell-check-api) provides not just spell check capabilities, but recognition of names, brand names, and slang.
* The [Linguistic Analysis API](https://www.microsoft.com/cognitive-services/en-us/linguistic-analysis-api) can break down sentence structure, performing part-of-speech tagging, etc.
* The [Entity Linking Intelligence Service](https://www.microsoft.com/cognitive-services/en-us/entity-linking-intelligence-service) annotates unstructured text with the relevant entities mentioned in the text (note this uses the Microsoft Graph, and can plug into your work knowledgebase, etc).
* The [Bing Speech API](https://www.microsoft.com/cognitive-services/en-us/speech-api) provides speech-to-text and text-to-speech conversion capabilities, and the [Speaker Recognition API](https://www.microsoft.com/cognitive-services/en-us/speaker-recognition-api) even enables speaker identification and verification through voice.
* So [many more](https://docs.microsoft.com/en-us/bot-framework/cognitive-services-bot-intelligence-overview): computer vision, face recognition, emotion detection, web search, image and video search, news search, etc.


## Q&A ((QnAmaker.ai)[https://qnamaker.ai/])

* The easiest [Question and Answer bot](https://docs.microsoft.com/en-us/bot-framework/azure-bot-service-template-question-answer)
* [QnA Apps](https://qnamaker.ai/Home/MyServices)
* So easy to import a FAQ. Let's use one I started for [PowerShell](https://poshcode.gitbooks.io/powershell-faq/)



## Other resources

* [VSTS Bot](https://blogs.msdn.microsoft.com/visualstudioalmrangers/2017/10/12/visual-studio-team-services-bot-vsts-bot-is-now-in-preview/)
* [Github Samples](https://github.com/Microsoft/BotBuilder-Samples)