using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region

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
