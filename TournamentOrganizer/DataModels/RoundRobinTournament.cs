using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// Implementation for a Round Robin style Tournament.
    /// </summary>
    internal partial class RoundRobinTournament : ObservableObject, ITournament
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
        public static string Description { get; } = "Each player is paired with each other player at least once.";

        /// <inheritdoc/>
        public ITournament.TournamentTypes Type { get; } = ITournament.TournamentTypes.RoundRobin;
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

        #region Constructors

        /// <summary>
        /// Generic constructor.
        /// </summary>
        public RoundRobinTournament() { }

        #endregion
    }
}
