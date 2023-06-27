using System.Net;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WalletApp.Application.Helpers;
using WalletApp.Application.Interfaces;
using WalletApp.Application.Models.Requests;
using WalletApp.Application.Models.Response;
using WalletApp.Application.Shared;
using WalletApp.Domain.Exceptions;
using WalletApp.Domain.Interfaces;
using WalletApp.Domain.Models;
using WalletApp.Infrastructure.Repository;

namespace WalletApp.Application.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<IdentityUser<Guid>> _userManager;
    private readonly AppRoleManager _roleManager;
    private readonly SignInManager<IdentityUser<Guid>> _signInManager;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly JwtSettings _jwtSettings;

    public AuthService(IUnitOfWork unitOfWork, UserManager<IdentityUser<Guid>> userManager, IMapper mapper,
        SignInManager<IdentityUser<Guid>> signInManager, AppRoleManager roleManager,
        JwtSettings jwtSettings)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
        _mapper = mapper;
        _signInManager = signInManager;
        _roleManager = roleManager;
        _jwtSettings = jwtSettings;
    }

    public async Task<AppResponse<SignInResponse>> SignInAsync(SignInVm model)
    {
        //Check if user with appropriate email 
        var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == model.Email);
        if (user == null)
        {
            throw new NotFoundException(new[] { "Wrong credentials" });
        }

        //Verify user password
        var validPassword = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
        if (!validPassword.Succeeded)
        {
            throw new NotFoundException(new[] { "Wrong credentials" });
        }

        //Get user role and extract claims from it
        var roles = await _userManager.GetRolesAsync(user);
        var role = await _roleManager.FindByNameAsync(roles.First());
        if (role == null)
        {
            throw NotFoundException.Default<IdentityRole<Guid>>();
        }

        var scopes = await _roleManager.GetClaimsAsync(role);

        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Email, user.Email!),
            new Claim(ClaimTypes.Name, user.UserName!),
            new Claim(ClaimTypes.Role, roles[0]),
            new Claim("scopes", string.Join(',', scopes.Select(x=>x.Type)))
        });

        //TODO: Token validation
        
        //Generate and store tokens
        var token = JwtTokenHelper.GenerateJwtToken(_jwtSettings, identity);
        await StoreTokenAsync(user, "access_token", token);

        var refreshToken = JwtTokenHelper.GenerateRefreshToken(_jwtSettings);
        await StoreTokenAsync(user, "refresh_token", refreshToken);

        return new AppResponse<SignInResponse>(HttpStatusCode.OK, null, new SignInResponse()
        {
            AccessToken = token,
            RefreshToken = refreshToken
        });
    }

    private async Task StoreTokenAsync(IdentityUser<Guid> user, string name, string value)
    {
        var existingToken = await _userManager.GetAuthenticationTokenAsync(user, "TokenProvider", name);
        if (existingToken != null)
        {
            await _userManager.RemoveAuthenticationTokenAsync(user, "TokenProvider", name);
        }

        var result = await _userManager.SetAuthenticationTokenAsync(user, "TokenProvider", name, value);
        if (!result.Succeeded)
        {
            throw new ValidationException(result.Errors.Select(x => x.Description));
        }
    }

    private async Task<string> RetrieveTokenAsync(IdentityUser<Guid> user, string purpose)
    {
        var token = await _userManager.GetAuthenticationTokenAsync(user, "TokenProvider", purpose);

        if (token == null)
        {
            throw new NotFoundException(new[] { "Token not found" });
        }

        return token;
    }
}