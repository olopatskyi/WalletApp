namespace WalletApp.Application.Models.Response;

public class SignInResponse
{
    public string AccessToken { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;
}