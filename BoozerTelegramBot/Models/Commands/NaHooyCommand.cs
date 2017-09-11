using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BoozerTelegramBot.Models.Commands
{
    public class NaHooyCommand : Command
    {
        public override string Name => "idinahoy";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Command logic -_-
            await client.SendTextMessageAsync(chatId, "HOOOY");
            //await client.SendTextMessageAsync(chatId, "IDI NA HOOOOY!", replyToMessageId: messageId);
        }

    }
}