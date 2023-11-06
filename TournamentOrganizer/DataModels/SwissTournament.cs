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

        /// <inheritdoc/>
        public static string Description { get; } = "A Swiss tournament is a non-eliminating tournament." +
                " Participants are ranked and paired based on their performance. No player will play the same" +
                " opponent twice.";

        /// <inheritdoc/>
        public ITournament.TournamentTypes Type { get; } = ITournament.TournamentTypes.Swiss;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
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
