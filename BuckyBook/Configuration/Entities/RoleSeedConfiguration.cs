using BuckyBook.Constant;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuckyBook.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                Name = Roles.Admin,
                NormalizedName = Roles.Admin.ToUpper()
            },

            new IdentityRole
            {
                Id = "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            },

             new IdentityRole
             {
                 Id = "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                 Name = Roles.Company,
                 NormalizedName = Roles.Company.ToUpper()
             },
              new IdentityRole
              {
                  Id = "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                  Name = Roles.Employer,
                  NormalizedName = Roles.Employer.ToUpper()
              });
        }
    }
}