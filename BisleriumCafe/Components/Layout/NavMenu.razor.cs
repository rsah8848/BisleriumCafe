using BisleriumCafe.Models.Enums;
using BisleriumCafe.Models;
using Microsoft.AspNetCore.Components;

namespace BisleriumCafe.Components.Layout;

public partial class NavMenu
{
    [Parameter]
    public string Username { get; set; } = null!;

    [Parameter]
    public Role Role { get; set; }

    [Parameter]
    public EventCallback LogoutHandler { get; set; }

    private bool CollapseNavMenu { get; set; } = true;

    private string? NavMenuCssClass => CollapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        CollapseNavMenu = !CollapseNavMenu;
    }
}