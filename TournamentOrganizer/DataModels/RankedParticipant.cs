using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// A Ranked Participant keeps track of a Score value that allows it to be
    /// uniquely compared against other Ranked Participants.
    /// </summary>
    internal partial class RankedParticipant : ObservableObject, IParticipant
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
        public RankedParticipant(string name)
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
