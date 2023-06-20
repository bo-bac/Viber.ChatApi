using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Keyboard object.
    /// </summary>
    public class RichMedia
    {
        public RichMedia() { }

        public RichMedia(params KeyboardButton[] buttons)
        {
            Buttons = buttons;
        }

        /// <summary>
        /// Represents size of block for grouping buttons during layout.
        /// </summary>
        /// <remarks>Possible values: 1-6. Default value: 6.</remarks>
        [JsonPropertyName("ButtonsGroupColumns")]
        public int? ButtonsGroupColumns { get; set; } = 6;

        /// <summary>
        /// Represents size of block for grouping buttons during layout.
        /// </summary>
        /// <remarks>Possible values: 1-7. Default value: 7 for Carousel content ; 2 for Keyboard.</remarks>
        [JsonPropertyName("ButtonsGroupRows")]
        public int? ButtonsGroupRows { get; set; } = 7;

        /// <summary>
        /// Array containing all keyboard buttons by order.
        /// </summary>
        [JsonPropertyName("Buttons")]
        public ICollection<KeyboardButton> Buttons { get; set; } = default!;

        /// <summary>
        /// Background color of the keyboard (valid color HEX value).
        /// </summary>
        [JsonPropertyName("BgColor")]
        public string BackgroundColor { get; set; } = default!;
    }
}
