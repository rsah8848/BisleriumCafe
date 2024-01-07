using BisleriumCafe.Models.Base;
using BisleriumCafe.Services;
using BisleriumCafe.Models;
using Microsoft.AspNetCore.Components;

namespace BisleriumCafe.Components.Pages;

public partial class Login
{
    [CascadingParameter]
    private GlobalState _globalState { get; set; }

    private string _username { get; set; }

    private string _password { get; set; }

    private string _errorMessage = "";

    protected override void OnInitialized()
    {
        _globalState.User = null;

        try
        {
            UserService.Login(UserService.SeedUsername, UserService.SeedPassword);
        }
        catch (Exception e)
        {
            _errorMessage = e.Message;
            Console.WriteLine(e.Message);
        }
    }

    private void LoginHandler()
    {
        try
        {
            _globalState.User = UserService.Login(_username, _password);

            NavManager.NavigateTo("/home");
        }
        catch (Exception e)
        {
            _errorMessage = e.Message;
            Console.WriteLine(e);
        }
    }
}