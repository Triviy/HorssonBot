﻿using Microsoft.Bot.Connector;
using App.Core.ImageManagers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Core.Commands
{
    internal class PostImageCommand : CommandBase
    {
        protected override string ExactCommand => "POST";
        protected override string[] StartWithCommands => new[] { "ИГОГО" };
        protected override string[] ContainsCommands => new[] {
            "ЛОШАД", "СПАМ", "ФЛУД", "РОЗБАВ", "СПАСИБ",
            "ЗАЕБ", "ДЕВУШ", "ДОБР", "ЕЩЕ", "ЕЩЁ", "ЗАЖИГАЙ", "ЖГИ", "ПОЖАЛУЙ"
        };
        protected override string[] Responses => new []{ "Держи", "Достаточно спама!", "Ок", "Сейчас поищу", "Лови лошадок", "Игого!"};
        protected override int ChanseToResponseInPercent => 30;

        protected override async Task<IList<string>> ExecuteInternalAsync(Activity activity)
        {
            var settings = new PosterSettings {
                SkipForCount = 7,
                ResultCount = BotState.Instance.Get(activity.Conversation?.Id, Constants.PostCountParameter, 1),
            };
            var imagePoster = new KorzikDailyPoster(Randomizer, new PatternMatcher());
            return await imagePoster.PostAsync(settings);
        }
    }
}