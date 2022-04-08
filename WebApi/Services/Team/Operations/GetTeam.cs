namespace MinimalApiDemo.Services.Team;

public static partial class TeamController
{
    public static TeamResource GetTeam(long id) => new TeamResource($"Team{id}", $"Conf{id}", "🏴󠁧󠁢󠁥󠁮󠁧󠁿");
}