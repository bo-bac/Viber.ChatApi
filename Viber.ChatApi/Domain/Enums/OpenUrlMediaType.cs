﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Determine the url media type.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum OpenUrlMediaType
    {
        /// <summary>
        /// Force browser usage.
        /// </summary>
        [EnumMember(Value = "not-media")]
        NotMedia = 1,

        /// <summary>
        /// Will be opened via media player.
        /// </summary>
        [EnumMember(Value = "video")]
        Video = 2,

        /// <summary>
        /// Client will play the gif in full screen mode.
        /// </summary>
        [EnumMember(Value = "gif")]
        Gif = 3,

        /// <summary>
        /// Client will open the picture in full screen mode.
        /// </summary>
        [EnumMember(Value = "picture")]
        Picture = 4,
    }
}