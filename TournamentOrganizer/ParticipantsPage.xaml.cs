using TournamentOrganizer.ViewModels;

namespace TournamentOrganizer;

/// <summary>
/// Allows the user to add and remove Participants from the Tournament.
/// </summary>
public partial class ParticipantsPage : ContentPage
{
    /// <summary>
    /// Constructs an AddParticipantsPage
    /// </summary>
    public ParticipantsPage(ParticipantsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}