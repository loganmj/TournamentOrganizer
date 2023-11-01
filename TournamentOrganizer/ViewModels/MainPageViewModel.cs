using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TournamentOrganizer.DataModels;

namespace TournamentOrganizer.ViewModels
{
    /// <summary>
    /// Controller for the MainPage view.
    /// The MainPage should have options to select a Tournament type,
    /// and to start a Tournament.
    /// </summary>
    internal partial class MainPageViewModel : ViewModelBase
    {
        #region Fields

        [ObservableProperty]
        private ObservableCollection<ITournament.TournamentTypes> _tournamentTypes;

        [ObservableProperty]
        private ITournament _tournament;

        #endregion

        #region Constructors

        /// <summary>
        /// Generic constructor.
        /// </summary>
        public MainPageViewModel()
        {
            Title = "Tournament Organizer";
            TournamentTypes = new ObservableCollection<ITournament.TournamentTypes>(Enum.GetValues(typeof(ITournament.TournamentTypes)).OfType<ITournament.TournamentTypes>().ToList());
        }

        #endregion

        #region Public Methods
        #endregion
    }
}
