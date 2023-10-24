namespace TournamentOrganizer.DataModels
{
    /// <summary>
    /// A Factory class for producing Participant objects.
    /// </summary>
    internal class ParticipantFactory
    {
        #region Public Methods

        /// <summary>
        /// Creates a Tournament object based on the passed in type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IParticipant CreateTournament(IParticipant.ParticipantTypes type, string name)
        {
            return type switch
            {
                IParticipant.ParticipantTypes.SimpleParticipant => new SimpleParticipant(name),
                IParticipant.ParticipantTypes.RankedParticipant => new RankedParticipant(name),
                _ => null,
            };
        }

        #endregion
    }
}
