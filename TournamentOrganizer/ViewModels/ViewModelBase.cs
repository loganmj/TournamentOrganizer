using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
