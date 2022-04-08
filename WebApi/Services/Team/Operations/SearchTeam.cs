namespace MinimalApiDemo.Services.Team;

public static partial class TeamController
{
    public static List<TeamResource> SearchTeam() => new List<TeamResource>
    {
        new TeamResource("Team1", "Conf1", "🏴󠁧󠁢󠁥󠁮󠁧󠁿"),
        new TeamResource("Team2", "Conf2", "🏴󠁧󠁢󠁥󠁮󠁧󠁿"),
        new TeamResource("Team3", "Conf3", "🏴󠁧󠁢󠁥󠁮󠁧󠁿")
    };
}