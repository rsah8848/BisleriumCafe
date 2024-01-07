using BisleriumCafe.Models.Base;
using BisleriumCafe.Services;
using BisleriumCafe.Models;

namespace BisleriumCafe.Components.Layout;

public partial class MainLayout
{
    private readonly GlobalState _globalState = new();

    protected override void OnInitialized()
    {
        UserService.SeedUser();
    }

    private void LogoutHandler()
    {
        _globalState.User = null;

        NavManager.NavigateTo("/login");
    }
}