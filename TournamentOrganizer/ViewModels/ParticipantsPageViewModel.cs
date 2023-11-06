using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TournamentOrganizer.DataModels;

namespace TournamentOrganizer.ViewModels
{
    /// <summary>
    /// Business logic for the AddParticipantsPage.
    /// </summary>
    public partial class ParticipantsPageViewModel : ViewModelBase, IQueryAttributable
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
        public ParticipantsPageViewModel()
        {
        }

        #endregion

        #region Public Methods

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Tournament = (ITournament)query["Tournament"];
            Title = $"{EnumCustomAttributeConverter.GetEnumMemberName(Tournament.Type)} Tournament | Add Participants";
        }

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
