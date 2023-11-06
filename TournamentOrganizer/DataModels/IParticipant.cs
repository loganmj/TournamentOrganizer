namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// Represents a participant in the tournament.
    /// </summary>
    public interface IParticipant
    {
        #region Enums

        /// <summary>
        /// A definition of different supported Participant types.
        /// </summary>
        public enum ParticipantTypes
        {
            SimpleParticipant,
            RankedParticipant
        }

        /// <summary>
        /// Enum definition of possible game results.
        /// </summary>
        public enum Result
        {
            Win,
            Loss,
            Draw
        }

        #endregion

        #region Properties

        /// <summary>
        /// The name of the Participant.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A record of wins and losses.
        /// </summary>
        public List<Result> Record { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a Participant to the list of Participants that have been played.
        /// </summary>
        /// <param name="participant"></param>
        public void AddPlayed(IParticipant participant);

        /// <summary>
        /// Checks if this Participant has played against a given Participant.
        /// </summary>
        public void HasPlayed(IParticipant participant);

        /// <summary>
        /// Adds a win/loss result to the Participant's record.
        /// </summary>
        /// <param name="result"></param>
        public void AddResult(Result result);

        #endregion
    }
}
