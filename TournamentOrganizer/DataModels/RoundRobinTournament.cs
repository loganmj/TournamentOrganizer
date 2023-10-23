using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.DataModels
{
    internal partial class RoundRobinTournament : ObservableObject, ITournament
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
