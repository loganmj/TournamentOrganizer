namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// Represents a tournament.
    /// </summary>
    internal interface ITournament
    {
        /*

        #region Fields

        [ObservableProperty]
        private List<Participant> _participants;

        [ObservableProperty]
        private int _currentRound;

        [ObservableProperty]
        private int _totalRounds;

        [ObservableProperty]
        private List<Pairing> _pairings;

        [ObservableProperty]
        private string _description;

        #endregion

        */

        #region Properties

        public List<Participant> Participants { get; set; }

        public int CurrentRound { get; set; }

        public int TotalRounds { get; set; }

        public List<Pairing> Pairings { get; set; }

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
