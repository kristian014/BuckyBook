using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuckyBook.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "ca9e7e82-f6f8-4353-9b45-3a9db1ba6176",
                UserId = "8ea993d6-11ab-4438-ac76-a9b951af77d5"
            },
             new IdentityUserRole<string>
             {
                 RoleId = "ba9a9e88-a7c4-3361-5a68-3b6cb1aa5166",
                 UserId = "6bc333d6-41cd-5539-ad37-a8c941bf66d5"
             },
             new IdentityUserRole<string>
             {
                 RoleId = "ac4c7e66-a4c3-2241-4a77-3c6ca1aa4456",
                 UserId = "6bd555a6-61fc-4339-bc37-a5c532bf99d5"
             },
             new IdentityUserRole<string>
             {
                 RoleId = "ca7a7e55-a6c3-2161-4a33-3c7cb3aa7866",
                 UserId = "6dc22d7-83cc-4799-cf47-a2c222bc22d5"
             }
           );
        }
    }
}