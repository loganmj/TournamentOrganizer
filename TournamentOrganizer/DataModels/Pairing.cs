using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// Represents a pairing between two Participants.
    /// </summary>
    internal partial class Pairing : ObservableObject
    {
        #region Fields

        [ObservableProperty]
        private Participant _participant1;

        [ObservableProperty]
        private Participant _participant2;

        #endregion

        #region Constructors

        /// <summary>
        /// Basic constructor requires two Participants.
        /// </summary>
        /// <param name="participant1"></param>
        /// <param name="participant2"></param>
        public Pairing(Participant participant1, Participant participant2)
        {
            Participant1 = participant1;
            Participant2 = participant2;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns a string representation of the Pairing.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion
    }
}
