﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;

namespace Core.Commands
{
    internal class HelpCommand : CommandBase
    {
        protected override string ExactCommand => "HELP";
        protected override string[] StartWithCommands => new[] { "/?", "-?" };
        protected override string[] ContainsCommands => new[] { "HELP", "ПОМОЩ", "ПОМОГ", "ЧТО ТУТ ДЕЛАТЬ", "ЧЯВО", "ЧЕ КАК" };
        protected override string[] Responses { get => null; }

        protected override async Task<IList<string>> ExecuteInternalAsync(Activity activity)
        {
            return new List<string>
            {
                "Бот лошадка IV:",
                "**HELP** -- справка",
                "**POST** -- картинки от Невседома",
                "**PROSESSION** -- фото от профессионалов",
                "**MOVIE** -- кино :)",
                "**ЧТО УГОДНО** -- картинки от Коржика",
                "**SET POST COUNT** -- настройка количества излучаемого добра",
            };
        }
    }
}