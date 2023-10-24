namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// Represents a tournament.
    /// </summary>
    internal interface ITournament
    {
        #region Enums

        /// <summary>
        /// The supported Tournament types.
        /// </summary>
        public enum TournamentTypes
        {
            RoundRobin,
            Swiss
        }

        #endregion

        #region Properties

        /// <summary>
        /// The list of Participants involved in the Tournament.
        /// </summary>
        public List<IParticipant> Participants { get; set; }

        /// <summary>
        /// The current Round count.
        /// </summary>
        public int CurrentRound { get; set; }

        /// <summary>
        /// The total number of rounds in the Tournament.
        /// </summary>
        public int TotalRounds { get; set; }

        /// <summary>
        /// The list of Pairings in the current Round.
        /// </summary>
        public List<Pairing> Pairings { get; set; }

        /// <summary>
        /// A text description of the Tournament type.
        /// </summary>
        public string Description { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a Participant to the Tournament.
        /// </summary>
        public void AddParticipant();

        /// <summary>
        /// Removes a Participant 
        /// </summary>
        public void RemoveParticipant();

        /// <summary>
        /// Generates a new list of Pairings and advances
        /// the CurrentRound count.
        /// </summary>
        public void AdvanceToNextRound();

        /// <summary>
        /// Returns a string representation of the Tournament type.
        /// This is required for Factory design pattern.
        /// </summary>
        /// <returns></returns>
        public string GetTournamentType();

        #endregion
    }
}
