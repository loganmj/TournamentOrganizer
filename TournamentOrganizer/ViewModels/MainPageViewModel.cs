using CommunityToolkit.Mvvm.ComponentModel;
using TournamentOrganizer.DataModels;

namespace TournamentOrganizer.ViewModels
{
    /// <summary>
    /// Controller for the MainPage view.
    /// </summary>
    internal partial class MainPageViewModel : ViewModelBase
    {
        #region Fields

        [ObservableProperty]
        private ITournament _tournament;

        #endregion

        #region Constructors

        /// <summary>
        /// Generic constructor.
        /// </summary>
        public MainPageViewModel()
        {
            // TEST
            _tournament = TournamentFactory.CreateTournament(ITournament.TournamentTypes.RoundRobin);
        }

        #endregion

        #region Public Methods
        #endregion
    }
}
