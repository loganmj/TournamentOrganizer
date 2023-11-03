using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

        [ObservableProperty]
        private int _selectedTournamentIndex;

        [ObservableProperty]
        private string _tournamentDescription;

        #endregion

        #region Constructors

        /// <summary>
        /// Generic constructor.
        /// </summary>
        public MainPageViewModel()
        {
            Title = "Tournament Organizer";
            TournamentTypes = new ObservableCollection<ITournament.TournamentTypes>(Enum.GetValues(typeof(ITournament.TournamentTypes)).OfType<ITournament.TournamentTypes>().ToList());
            SelectedTournamentIndex = 0;
            TournamentDescription = TournamentFactory.GetDescription((ITournament.TournamentTypes)SelectedTournamentIndex);
            PropertyChanged += OnPropertyChanged;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Updates data when a property changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals(nameof(SelectedTournamentIndex))) 
            {
                TournamentDescription = TournamentFactory.GetDescription((ITournament.TournamentTypes)SelectedTournamentIndex);
            }
        }

        #endregion

        #region Public Methods
        #endregion
    }
}
