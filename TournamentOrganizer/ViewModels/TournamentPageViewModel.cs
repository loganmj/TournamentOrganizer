using TournamentOrganizer.DataModels;

namespace TournamentOrganizer.ViewModels
{
    /// <summary>
    /// ViewModel for the TournamentPage View.
    /// </summary>
    internal class TournamentPageViewModel : ViewModelBase
    {
        #region Fields

        private readonly ITournament _tournament;

        #endregion

        #region Constructors

        /// <summary>
        /// This constructor requires an ITournament parameter reference
        /// that we can perform operations on.
        /// </summary>
        /// <param name="tournament"></param>
        public TournamentPageViewModel(ITournament tournament)
        {
            _tournament = tournament;
        }

        #endregion
    }
}
