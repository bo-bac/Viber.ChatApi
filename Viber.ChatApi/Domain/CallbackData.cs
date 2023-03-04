using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Webhook callback data.
    /// </summary>
    public class CallbackData
    {
        /// <summary>
        /// Callback type - which event triggered the callback.
        /// </summary>
        [JsonPropertyName("event")]
        public EventType Event { get; set; }

        /// <summary>
        /// Unique ID of the message.
        /// </summary>
        [JsonPropertyName("message_token")]
        public long MessageToken { get; set; }

        /// <summary>
        /// Time of the event that triggered the callback (epoch time).
        /// </summary>
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Unique Viber user id.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Viber user.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; } = default!;

        /// <summary>
        /// Indicated whether a user is already subscribed.
        /// </summary>
        [JsonPropertyName("subscribed")]
        public bool? Subscribed { get; set; }

        /// <summary>
        /// Any additional parameters added to the deep link used to access the conversation passed as a string.
        /// </summary>
        /// <remarks>
        /// See deep link section for additional information: https://developers.viber.com/docs/tools/deep-links.
        /// </remarks>
        [JsonPropertyName("context")]
        public string Context { get; set; } = default!;

        /// <summary>
        /// A string describing the failure.
        /// </summary>
        [JsonPropertyName("desc")]
        public string? Description { get; set; }

        /// <summary>
        /// Viber user.
        /// </summary>
        [JsonPropertyName("sender")]
        public User Sender { get; set; } = default!;

        /// <summary>
        /// Message object.
        /// </summary>
        [JsonIgnore]
        public MessageBase Message { get; set; } = default!;

        /// <summary>
        /// Message object.
        /// </summary>
        [JsonInclude]
        public JsonObject message
        {
            get
            {
                return default!;

                //Type type = Message.Type switch
                //{
                //    MessageType.Text => typeof(TextMessage),
                //    MessageType.Picture => typeof(PictureMessage),
                //    MessageType.Video => typeof(VideoMessage),
                //    MessageType.File => typeof(FileMessage),
                //    MessageType.Location => typeof(LocationMessage),
                //    MessageType.Contact => typeof(ContactMessage),
                //    MessageType.Sticker => typeof(StickerMessage),
                //    MessageType.CarouselContent => throw new NotImplementedException(),
                //    MessageType.Url => typeof(UrlMessage),
                //    _ => throw new ArgumentOutOfRangeException(),
                //};

                //return JsonSerializer.SerializeToNode(Message, type)?.AsObject()!;
            }
            private set
            {
                var messageType = value["type"].Deserialize<MessageType>();
                Type type = messageType switch
                {
                    MessageType.Text => typeof(TextMessage),
                    MessageType.Picture => typeof(PictureMessage),
                    MessageType.Video => typeof(VideoMessage),
                    MessageType.File => typeof(FileMessage),
                    MessageType.Location => typeof(LocationMessage),
                    MessageType.Contact => typeof(ContactMessage),
                    MessageType.Sticker => typeof(StickerMessage),
                    MessageType.CarouselContent => throw new NotImplementedException(),
                    MessageType.Url => typeof(UrlMessage),
                    _ => throw new ArgumentOutOfRangeException(),
                };
                Message = (JsonSerializer.Deserialize(value, type) as MessageBase) ?? throw new NullReferenceException();
            }
        }
    }
}