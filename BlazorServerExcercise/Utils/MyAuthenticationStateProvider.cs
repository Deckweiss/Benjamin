using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;

namespace BlazorServerExcercise.Utils
{
    public class MyAuthenticationStateProvider : ServerAuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            AuthenticationState result = await base.GetAuthenticationStateAsync();
            return result;
        }
    }
}