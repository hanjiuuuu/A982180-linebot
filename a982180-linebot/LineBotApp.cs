using System.Net.Mime;
using Line.Messaging;
using Line.Messaging.Webhooks;

namespace a982180_linebot;

public class LineBotApp : WebhookApplication
{
    private readonly LineMessagingClient _messagingClient;
    public LineBotApp(LineMessagingClient lineMessagingClient)
    {
        _messagingClient = lineMessagingClient;
    }

    protected override async Task OnMessageAsync(MessageEvent ev)
    {
        var result = null as List<ISendMessage>;

        switch (ev.Message)
        {
            //文字訊息
            case TextEventMessage textMessage:
            {
                //頻道Id
                var channelId = ev.Source.Id;
                //使用者Id
                var userId = ev.Source.UserId;
                
                var Text = ((TextEventMessage)ev.Message).Text;
                var outputText = Text;
                
                if (Text.Contains("嗨") && Text.Contains("你好"))
                {
                    Text = "哈囉";
                }

                
                //回傳 hellow
                result = new List<ISendMessage>
                {
                    new TextMessage("怎麼會這樣"+ ((TextEventMessage) ev.Message).Text)
                };
            }
                break;
        }

        if (result != null)
            await _messagingClient.ReplyMessageAsync(ev.ReplyToken, result);
    }
}