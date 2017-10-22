namespace PortableSteam.Fluent.General
{
    using PortableSteam.Fluent.General.IPlayerService;
    using PortableSteam.Infrastructure;
    using PortableSteam.Interfaces.General.IPlayerService;
    using System;
    using System.ComponentModel;

    public class PlayerServiceBuilderHandler : SteamBaseBuilderHandler
    {
        public PlayerServiceBuilderHandler(string key) : base(key) { }
        /// <summary>
        /// Get badges for player.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetBadgesBuilder GetBadges(SteamIdentity identity)
        {
            return new GetBadgesBuilder(new GetBadgesRequest(this.Key) { SteamID = identity.SteamID });
        }
        /// <summary>
        /// Get badge progress for player.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetCommunityBadgeProgressBuilder GetCommunityBadgeProgress(SteamIdentity identity)
        {
            return new GetCommunityBadgeProgressBuilder(new GetCommunityBadgeProgressRequest(this.Key) { SteamID = identity.SteamID });
        }
        /// <summary>
        /// Get owned games for player.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetOwnedGamesBuilder GetOwnedGames(SteamIdentity identity)
        {
            return new GetOwnedGamesBuilder(new GetOwnedGamesRequest(this.Key) { SteamID = identity.SteamID });
        }
        /// <summary>
        /// Get recently played games for player.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetRecentlyPlayedGamesBuilder GetRecentlyPlayedGames(SteamIdentity identity)
        {
            return new GetRecentlyPlayedGamesBuilder(new GetRecentlyPlayedGamesRequest(this.Key) { SteamID = identity.SteamID });
        }
        /// <summary>
        /// Get player level.
        /// </summary>
        /// <param name="identity">The identity of the player.</param>
        /// <returns></returns>
        public GetSteamLevelBuilder GetSteamLevel(SteamIdentity identity)
        {
            return new GetSteamLevelBuilder(new GetSteamLevelRequest(this.Key) { SteamID = identity.SteamID });
        }

        #region Hidden

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return this.GetType();
        }

        #endregion
    }
}
