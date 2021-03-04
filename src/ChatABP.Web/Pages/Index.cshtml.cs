using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ChatABP.Web.Pages
{
    public class IndexModel : ChatABPPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}