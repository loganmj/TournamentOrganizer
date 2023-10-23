using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// Represents a tournament.
    /// </summary>
    internal abstract partial class Tournament : ObservableObject
    {
        #region Fields

        [ObservableProperty]
        private List<Participant> _participants;

        [ObservableProperty]
        private int _currentRound;

        [ObservableProperty]
        private int _totalRounds;

        [ObservableProperty]
        private List<Pairing> _pairings;

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a Participant to the Tournament.
        /// </summary>
        public abstract void AddParticipant();

        /// <summary>
        /// Removes a Participant 
        /// </summary>
        public abstract void RemoveParticipant();

        #endregion
    }
}
