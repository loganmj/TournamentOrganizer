namespace TournamentOrganizer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Add routing to AddParticipants page
            Routing.RegisterRoute(nameof(AddParticipantsPage), typeof(AddParticipantsPage));
        }
    }
}