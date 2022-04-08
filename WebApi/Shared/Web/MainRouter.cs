using MinimalApiDemo.Services.Team;

namespace MinimalApiDemo.Shared.Web;

public static class MainRouter 
{
    public static void AddWebApiRoutes(this WebApplication app)
    {
        app.AddTeamRoutes();
    }
}