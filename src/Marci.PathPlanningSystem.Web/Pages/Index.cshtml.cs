using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Marci.PathPlanningSystem.Web.Pages;

public class IndexModel : PathPlanningSystemPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
