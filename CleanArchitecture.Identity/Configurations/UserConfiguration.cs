using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                    new ApplicationUser
                    {
                        Id = "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                        Email = "admin@locahost.com",
                        NormalizedEmail = "admin@locahost.com",
                        Nombre = "admin",
                        Apellidos = "Admin",
                        UserName = "admin",
                        NormalizedUserName = "admin",
                        PasswordHash = hasher.HashPassword(null, "admin2025$"),
                        EmailConfirmed = true,
                    },
                    new ApplicationUser
                    {
                        Id = "294d249b-9b57-48c1-9689-11a91abb6447",
                        Email = "Eduardo@locahost.com",
                        NormalizedEmail = "Eduardo@locahost.com",
                        Nombre = "Eduardo",
                        Apellidos = "Eduardo",
                        UserName = "Eduardo",
                        NormalizedUserName = "Eduardo",
                        PasswordHash = hasher.HashPassword(null, "admin2025$"),
                        EmailConfirmed = true,
                    }

                );


        }
    }
}
