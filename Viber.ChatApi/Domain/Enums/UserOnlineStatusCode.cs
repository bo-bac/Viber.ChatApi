namespace Viber.ChatApi
{
    /// <summary>
    /// Online status codes.
    /// </summary>
    public enum UserOnlineStatusCode
    {
        /// <summary>
        /// Online.
        /// </summary>
        Online = 0,

        /// <summary>
        /// Offline.
        /// </summary>
        Offline = 1,

        /// <summary>
        /// Undisclosed. User set Viber to hide status
        /// </summary>
        Undisclosed = 2,

        /// <summary>
        /// Try later - internal error.
        /// </summary>
        TryLater = 3,

        /// <summary>
        /// Not a Viber user / unsubscribed / unregistered.
        /// </summary>
        Unavailable = 4
    }
}