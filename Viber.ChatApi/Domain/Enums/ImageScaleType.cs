using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Viber.ChatApi;

/// <summary>
/// Image scale type. optional (api level 6).
/// </summary>
[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum ImageScaleType
{
    /// <summary>
    /// Crop - contents scaled to fill with fixed aspect. some portion of content may be clipped.
    /// </summary>
    [EnumMember(Value = "crop")]
    Crop = 1,

    /// <summary>
    /// Fill  - contents scaled to fill without saving fixed aspect.
    /// </summary>
    [EnumMember(Value = "fill")]
    Fill = 2,

    /// <summary>
    /// Fit - at least one axis (X or Y) will fit exactly, aspect is saved.
    /// </summary>
    [EnumMember(Value = "fit")]
    Fit = 3
}