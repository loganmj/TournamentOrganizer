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
        private Tournament _tournament;

        #endregion

        #region Constructors

        /// <summary>
        /// Generic constructor.
        /// </summary>
        public MainPageViewModel()
        {

        }

        #endregion

        #region Public Methods
        #endregion
    }
}
