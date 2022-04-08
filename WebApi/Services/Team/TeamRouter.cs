namespace MinimalApiDemo.Services.Team;

public static class TeamRouter
{
    public static void AddTeamRoutes(this WebApplication app)
    {
        app.MapGet("/teams", TeamController.SearchTeam);
        app.MapGet("/teams/{id}", TeamController.GetTeam);
    }
}