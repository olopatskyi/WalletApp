using System.Security.Claims;
using WalletApp.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace WalletApp.Infrastructure.Repository;

public class AppRoleManager : RoleManager<IdentityRole<Guid>>
{
    private readonly DatabaseContext _databaseContext;

    public AppRoleManager(IRoleStore<IdentityRole<Guid>> store,
        IEnumerable<IRoleValidator<IdentityRole<Guid>>> roleValidators, ILookupNormalizer keyNormalizer,
        IdentityErrorDescriber errors, ILogger<RoleManager<IdentityRole<Guid>>> logger, DatabaseContext databaseContext)
        : base(store, roleValidators,
            keyNormalizer, errors, logger)
    {
        _databaseContext = databaseContext;
    }

    public override async Task<IList<Claim>> GetClaimsAsync(IdentityRole<Guid> role)
    {
        var query = _databaseContext.RoleClaims.Where(x => x.RoleId == role.Id)
            .Select(x => new Claim(x.ClaimType!, string.Empty));
        
        return await query.AsNoTracking().ToListAsync();
    }
}