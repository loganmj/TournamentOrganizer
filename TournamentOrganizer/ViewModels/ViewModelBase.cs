using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.ViewModels
{
    /// <summary>
    /// A base class for ViewModel objects.
    /// </summary>
    public partial class ViewModelBase : ObservableObject
    {
        #region Constants

        public string GLOBAL_COLOR_BLUE = "#56C0CC";

        #endregion

        #region Fields

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string _title;

        #endregion
    }
}
