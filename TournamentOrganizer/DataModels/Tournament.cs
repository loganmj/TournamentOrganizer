using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// Represents a tournament.
    /// </summary>
    internal partial class Tournament : ObservableObject
    {
        #region Fields

        [ObservableProperty]
        private List<Participant> _participants;

        #endregion

        #region Constructors

        /// <summary>
        /// Generic constructor.
        /// </summary>
        public Tournament() { }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a Participant to the Tournament.
        /// </summary>
        public void AddParticipant() { }

        /// <summary>
        /// Removes a Participant 
        /// </summary>
        public void RemoveParticipant() { }

        /// <summary>
        /// Returns a string representation of the Tournament.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion
    }
}
