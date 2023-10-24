using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// A simple, feature light Participant class.
    /// </summary>
    internal partial class SimpleParticipant : ObservableObject, IParticipant
    {
        #region Fields

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private List<IParticipant.Result> _record;

        #endregion

        #region Constructors

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="name"></param>
        public SimpleParticipant(string name)
        {
            Name = name;
        }

        #endregion

        #region Public Methods

        public void AddPlayed(IParticipant participant) { }

        public void HasPlayed(IParticipant participant) { }

        public void AddResult(IParticipant.Result result) { }

        #endregion
    }
}
