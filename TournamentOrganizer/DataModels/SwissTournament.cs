using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// Implementation for a Swiss style Tournament.
    /// </summary>
    internal partial class SwissTournament : ObservableObject, ITournament
    {
        #region Fields

        [ObservableProperty]
        private List<IParticipant> _participants;

        [ObservableProperty]
        private int _currentRound;

        [ObservableProperty]
        private int _totalRounds;

        [ObservableProperty]
        private List<Pairing> _pairings;

        #endregion

        #region Properties

        /// <summary>
        /// Returns the Tournament description.
        /// </summary>
        public static string Description { get; } = "A Swiss-system tournament is a non-eliminating tournament format that" +
                " features a fixed number of rounds of competition, but considerably fewer than for" +
                " a round-robin tournament; thus each competitor (team or individual) does not play" +
                " all the other competitors. Competitors meet one-on-one in each round and are paired" +
                " using a set of rules designed to ensure that each competitor plays opponents with a" +
                " similar running score, but does not play the same opponent more than once. The winner" +
                " is the competitor with the highest aggregate points earned in all rounds. With an even" +
                " number of participants, all competitors play in each round.";

        #endregion

        #region Constructors

        public SwissTournament() { }

        #endregion

        #region Public Methods

        public void AddParticipant()
        {
            throw new NotImplementedException();
        }

        public void AdvanceToNextRound()
        {
            throw new NotImplementedException();
        }

        public string GetTournamentType()
        {
            throw new NotImplementedException();
        }

        public void RemoveParticipant()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
