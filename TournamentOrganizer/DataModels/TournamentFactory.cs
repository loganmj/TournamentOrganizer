namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// A static class used to create new Tournament objects.
    /// </summary>
    internal static class TournamentFactory
    {
        #region Public Methods

        /// <summary>
        /// Creates a Tournament object based on the passed in type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ITournament CreateTournament(ITournament.TournamentTypes type)
        {
            return type switch
            {
                ITournament.TournamentTypes.RoundRobin => new RoundRobinTournament(),
                ITournament.TournamentTypes.Swiss => new SwissTournament(),
                _ => null,
            };
        }

        #endregion
    }
}
