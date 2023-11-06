using TournamentOrganizer.DataModels;
using TournamentOrganizer.ViewModels;

namespace TournamentOrganizer.Views;

/// <summary>
/// Allows the user to add and remove Participants from the Tournament.
/// </summary>
public partial class AddParticipantsPage : ContentPage
{
    /// <summary>
    /// Constructs an AddParticipantsPage
    /// </summary>
    public AddParticipantsPage()
    {
        InitializeComponent();
        BindingContext = new AddParticipantsPageViewModel();
    }
}