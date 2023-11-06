using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TournamentOrganizer.DataModels;

namespace TournamentOrganizer.ViewModels
{
    /// <summary>
    /// Business logic for the AddParticipantsPage.
    /// </summary>
    [QueryProperty("Tournament", "Tournament")]
    internal partial class AddParticipantsPageViewModel : ViewModelBase
    {
        #region Fields

        [ObservableProperty]
        private ITournament _tournament;

        #endregion

        #region Constructors

        /// <summary>
        /// This constructor requires an ITournament parameter reference
        /// that we can perform operations on.
        /// </summary>
        public AddParticipantsPageViewModel()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns to the previous page.
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        public async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        #endregion
    }
}
