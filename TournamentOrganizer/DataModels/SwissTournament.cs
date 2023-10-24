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

        [ObservableProperty]
        private string _description;

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
