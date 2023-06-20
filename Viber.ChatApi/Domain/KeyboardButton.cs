using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Keyboard button.
    /// </summary>
    public class KeyboardButton
    {
        /// <summary>
        /// Type of action pressing the button will perform.
        /// </summary>
        /// <remarks>Default value: <see cref="KeyboardActionType.Reply"/>.</remarks>
        [JsonPropertyName("ActionType")]
        public KeyboardActionType? ActionType { get; set; }

        /// <summary>
        /// Text for 'reply' and 'none'. ActionType or URL for 'open-url'.
        /// </summary>
        /// <remarks>For ActionType 'reply' - text. For ActionType 'open-url' - Valid URL.</remarks>
        [JsonPropertyName("ActionBody")]
        public string ActionBody { get; set; } = default!;

        /// <summary>
        /// Text to be displayed on the button. Can contain some HTML tags.
        /// </summary>
        /// <remarks>
        /// Free text. Valid and allowed HTML tags Max 250 characters.
        /// If the text is too long to display on the button it will be cropped and ended with "…".
        /// </remarks>
        [JsonPropertyName("Text")]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Button width in columns.
        /// </summary>
        /// <remarks>Possible values: 1-6. Default value: 6.</remarks>
        [JsonPropertyName("Columns")]
        public int? Columns { get; set; }

        /// <summary>
        /// Button height in rows.
        /// </summary>
        /// <remarks>Possible values: 1-2. Default value: 1.</remarks>
        [JsonPropertyName("Rows")]
        public int? Rows { get; set; }

        /// <summary>
        /// Background color of button (valid color HEX value).
        /// </summary>
        [JsonPropertyName("BgColor")]
        public string BackgroundColor { get; set; } = default!;

        /// <summary>
        /// Determine whether the user action is presented in the conversation.
        /// </summary>
        [JsonPropertyName("Silent")]
        public bool Silent { get; set; }

        /// <summary>
        /// Type of the background media.
        /// </summary>
        /// <remarks>
        /// Default value: <see cref="Viber.ChatApi.BackgroundMediaType.Picture"/>.
        /// Max size: 500 kb.
        /// </remarks>
        [JsonPropertyName("BgMediaType")]
        public BackgroundMediaType? BackgroundMediaType { get; set; }

        /// <summary>
        /// URL for background media content (picture or gif). Will be placed with aspect to fill logic.
        /// </summary>
        [JsonPropertyName("BgMedia")]
        public string BackgroundMedia { get; set; } = default!;

        /// <summary>
        /// When true - animated background media (gif) will loop continuously. When false - animated background media will play once and stop.
        /// </summary>
        /// <remarks>Default value: true.</remarks>
        [JsonPropertyName("BgLoop")]
        public bool? BackgroundLoop { get; set; }

        /// <summary>
        /// URL of image to place on top of background (if any).
        /// Can be a partially transparent image that will allow showing some of the background.
        /// Will be placed with aspect to fill logic.
        /// </summary>
        /// <remarks>JPEG and PNG files are supported. Max size: 500 kb.</remarks>
        [JsonPropertyName("Image")]
        public string Image { get; set; } = default!;

        /////// <summary>
        /////// Options for scaling the bounds of an image to the bounds of this view.
        /////// </summary>
        /////// <remarks>Optional (api level 6).</remarks>
        ////[JsonPropertyName("ImageScaleType")]
        ////public ImageScaleType ImageScaleType { get; set; }

        /// <summary>
        /// Vertical alignment of the text.
        /// </summary>
        /// <remarks>Default value: <see cref="Viber.ChatApi.TextVerticalAlign.Middle"/>.</remarks>
        [JsonPropertyName("TextVAlign")]
        public TextVerticalAlign? TextVerticalAlign { get; set; }

        /// <summary>
        /// Horizontal align of the text.
        /// </summary>
        /// <remarks>Default value: <see cref="Viber.ChatApi.TextHorizontalAlign.Center"/>.</remarks>
        [JsonPropertyName("TextHAlign")]
        public TextHorizontalAlign? TextHorizontalAlign { get; set; }

        /// <summary>
        /// Custom paddings for the text in points. The value is an array of Integers [top, left, bottom, right].
        /// </summary>
        /// <remarks>Possible values: per padding 0-12. Default value: [12,12,12,12].</remarks>
        [JsonPropertyName("TextPaddings")]
        public int[] TextPaddings { get; set; } = default!;

        /// <summary>
        /// Text opacity.
        /// </summary>
        /// <remarks>Possible values: 0-100. Default value: 100.</remarks>
        [JsonPropertyName("TextOpacity")]
        public int? TextOpacity { get; set; }

        /// <summary>
        /// Text size out of 3 available options.
        /// </summary>
        /// <remarks>Default value: <see cref="Viber.ChatApi.TextSize.Regular"/>.</remarks>
        [JsonPropertyName("TextSize")]
        public TextSize? TextSize { get; set; }

        /// <summary>
        /// Determine the open-url action result, in app or external browser.
        /// </summary>
        /// <remarks>Default value: <see cref="OpenUrlType.Internal"/>.</remarks>
        [JsonPropertyName("OpenURLType")]
        public OpenUrlType? UrlOpenType { get; set; }

        /// <summary>
        /// Determine the url media type.
        /// </summary>
        /// <remarks>Default value: <see cref="OpenUrlMediaType.NotMedia"/>.</remarks>
        [JsonPropertyName("OpenURLMediaType")]
        public OpenUrlMediaType? UrlMediaType { get; set; }

        /// <summary>
        /// Background gradient to use under text, Works only when TextVAlign is equal to top or bottom	Hex value (6 characters)
        /// </summary>
        [JsonPropertyName("TextBgGradientColor")]
        public string TextBackgroundGradientColor { get; set; } = default!;
    }
}