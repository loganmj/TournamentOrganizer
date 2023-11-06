using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentOrganizer.DataModels;

namespace TournamentOrganizer.ViewModels
{
    /// <summary>
    /// Business logic for the AddParticipantsPage.
    /// </summary>
    class AddParticipantsPageViewModel
    {
        #region Fields

        private readonly ITournament _tournament;

        #endregion

        #region Constructors

        /// <summary>
        /// This constructor requires an ITournament parameter reference
        /// that we can perform operations on.
        /// </summary>
        /// <param name="tournament"></param>
        public AddParticipantsPageViewModel(ITournament tournament)
        {
            _tournament = tournament;
        }

        #endregion
    }
}
