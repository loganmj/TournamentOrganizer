using CommunityToolkit.Mvvm.ComponentModel;

namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// Represents a participant in the tournament.
    /// </summary>
    internal partial class Participant : ObservableObject
    {
        #region Fields

        /// <summary>
        /// The name of the Participant.
        /// </summary>
        [ObservableProperty]
        private string _name;

        #endregion

        #region Constructors

        /// <summary>
        /// Basic constructor requires a name for the participant.
        /// </summary>
        /// <param name="name"></param>
        public Participant(string name)
        {
            Name = name;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns a string representation of the Participant.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Participant | Name: {Name}";
        }

        #endregion
    }
}
