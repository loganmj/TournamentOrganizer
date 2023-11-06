namespace TournamentOrganizer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Add routing to Participants page
            Routing.RegisterRoute(nameof(ParticipantsPage), typeof(ParticipantsPage));
        }
    }
}