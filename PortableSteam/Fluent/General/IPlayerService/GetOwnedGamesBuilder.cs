namespace PortableSteam.Fluent.General.IPlayerService
{
    using PortableSteam.Fluent;
    using PortableSteam.Interfaces.General.IPlayerService;
    using System;
    using System.ComponentModel;

    public class GetOwnedGamesBuilder : SteamBaseBuilder<GetOwnedGamesRequest, GetOwnedGamesResponse, GetOwnedGamesBuilder>
    {
        public GetOwnedGamesBuilder(GetOwnedGamesRequest request)
            : base(request)
        {
        }

        /// <summary>
        /// Whether or not to include additional details of apps - name and images.
        /// </summary>
        /// <returns></returns>
        public GetOwnedGamesBuilder IncludeAppInfo()
        {
            this.Request.IncludeAppInfo = true;
            return this;
        }

        /// <summary>
        /// Whether or not to list free-to-play games in the results.
        /// </summary>
        /// <returns></returns>
        public GetOwnedGamesBuilder IncludePlayedFreeGames()
        {
            this.Request.IncludePlayedFreeGames = true;
            return this;
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
        public new Type GetType()
        {
            return this.GetType();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion Hidden
    }
}
