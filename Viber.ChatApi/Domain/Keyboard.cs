using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Keyboard object.
	/// </summary>
	public class Keyboard
	{
		public Keyboard() { }

        public Keyboard(params KeyboardButton[] buttons) 
		{
			Buttons = buttons;
        }

        /// <summary>
		/// Array containing all keyboard buttons by order.
		/// </summary>
		[JsonPropertyName("Buttons")]
		public ICollection<KeyboardButton> Buttons { get; set; } = default!;

        /// <summary>
        /// When true - the keyboard will always be displayed with the same height as the native keyboard.
        /// When false - short keyboards will be displayed with the minimal possible height.
        /// Maximal height will be native keyboard height.
        /// </summary>
        [JsonPropertyName("DefaultHeight")]
		public bool DefaultHeight { get; set; }

		/// <summary>
		/// Background color of the keyboard (valid color HEX value).
		/// </summary>
		[JsonPropertyName("BgColor")]
		public string BackgroundColor { get; set; } = default!;

        /// <summary>
        /// How much percent of free screen space in chat should be taken by keyboard.
        /// The final height will be not less than height of system keyboard.
        /// </summary>
        /// <remarks>Possible values: 40-70.</remarks>
        [JsonPropertyName("CustomDefaultHeight")]
		public int? CustomDefaultHeight { get; set; }

		/// <summary>
		/// Allow use custom aspect ratio for Carousel content blocks.
		/// Scales the height of the default square block (which is defined on client side) to the given value in percents.
		/// It means blocks can become not square and it can be used to create rich messages with correct custom aspect ratio.
		/// This is applied to all blocks in the Carousel content.
		/// </summary>
		/// <remarks>Possible values: 20-100. Default value: 100.</remarks>
		[JsonPropertyName("HeightScale")]
		public int? HeightScale { get; set; }

		/// <summary>
		/// Represents size of block for grouping buttons during layout.
		/// </summary>
		/// <remarks>Possible values: 1-6. Default value: 6.</remarks>
		[JsonPropertyName("ButtonsGroupColumns")]
		public int? ButtonsGroupColumns { get; set; }

		/// <summary>
		/// Represents size of block for grouping buttons during layout.
		/// </summary>
		/// <remarks>Possible values: 1-7. Default value: 7 for Carousel content ; 2 for Keyboard.</remarks>
		[JsonPropertyName("ButtonsGroupRows")]
		public int? ButtonsGroupRows { get; set; }

		/// <summary>
		/// Customize the keyboard input field.
		/// </summary>
		[JsonPropertyName("InputFieldState")]
		public KeyboardInputFieldState? InputFieldState { get; set; }
	}
}
