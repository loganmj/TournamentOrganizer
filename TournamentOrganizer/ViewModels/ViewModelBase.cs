using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.ViewModels
{
    /// <summary>
    /// A base class for ViewModel objects.
    /// </summary>
    internal partial class ViewModelBase : ObservableObject
    {
        #region Fields

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string _title;

        #endregion
    }
}
