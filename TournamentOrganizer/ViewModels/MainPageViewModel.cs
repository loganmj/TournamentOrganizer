using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        private ObservableCollection<string> _tournamentTypes;
        // private ObservableCollection<ITournament.TournamentTypes> _tournamentTypes;

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

            TournamentTypes = new ObservableCollection<string>(EnumCustomAttributeConverter.GetEnumMemberNames<ITournament.TournamentTypes>());
            // TournamentTypes= new ObservableCollection<string>(Enum.GetNames(typeof(ITournament.TournamentTypes)));
            // TournamentTypes = new ObservableCollection<ITournament.TournamentTypes>(Enum.GetValues(typeof(ITournament.TournamentTypes)).OfType<ITournament.TournamentTypes>().ToList());
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

        /// <summary>
        /// Pushes the AddParticipants page onto the navigation stack.
        /// </summary>
        [RelayCommand]
        public async Task ProgressToAddParticipantsPage()
        {
            // Create a new Tournament of the selected type.
            Tournament = TournamentFactory.CreateTournament((ITournament.TournamentTypes)SelectedTournamentIndex);

            // Navigate to the AddParticipants page, passing in the Tournament object.
            await Shell.Current.GoToAsync(nameof(AddParticipantsPage), new Dictionary<string, object>
            {
                {nameof(AddParticipantsPage), Tournament }
            });
        }

        #endregion
    }
}
