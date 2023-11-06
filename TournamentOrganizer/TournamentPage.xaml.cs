using TournamentOrganizer.DataModels;
using TournamentOrganizer.ViewModels;

namespace TournamentOrganizer;

/// <summary>
/// This page runs the Tournament.
/// </summary>
public partial class TournamentPage : ContentPage
{
    /// <summary>
    /// Constructs a Tournament Page using a passed in Tournament object.
    /// </summary>
    /// <param name="tournament"></param>
    public TournamentPage(ITournament tournament)
    {
        InitializeComponent();
        BindingContext = new TournamentPageViewModel(tournament);
    }
}