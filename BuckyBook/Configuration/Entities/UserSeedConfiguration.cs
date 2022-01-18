using BuckyBook.Data;
using BuckyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuckyBook.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
            {
                Id = "8ea993d6-11ab-4438-ac76-a9b951af77d5",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                PhoneNumber = "07563223432",
                Name = "system",
                City = "Hull",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            },

             new ApplicationUser
             {
                 Id = "6bc333d6-41cd-5539-ad37-a8c941bf66d5",
                 Email = "user@localhost.com",
                 NormalizedEmail = "USER@LOCALHOST.COM",
                 NormalizedUserName = "USER@LOCALHOST.COM",
                 UserName = "user@localhost.com",
                 Name = "system",
                 PhoneNumber = "07563223562",
                 City = "London",
                 PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                 EmailConfirmed = true
             },

             new ApplicationUser
             {
                 Id = "6bd555a6-61fc-4339-bc37-a5c532bf99d5",
                 Email = "company@localhost.com",
                 NormalizedEmail = "COMPANY@LOCALHOST.COM",
                 NormalizedUserName = "COMPANY@LOCALHOST.COM",
                 UserName = "company@localhost.com",
                 Name = "system",
                 PhoneNumber = "07563223245",
                 City = "Doncaster",
                 PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                 EmailConfirmed = true
             },

              new ApplicationUser
              {
                  Id = "6dc22d7-83cc-4799-cf47-a2c222bc22d5",
                  Email = "employer@localhost.com",
                  NormalizedEmail = "EMPLOYER@LOCALHOST.COM",
                  NormalizedUserName = "EMPLOYER@LOCALHOST.COM",
                  UserName = "employer@localhost.com",
                  Name = "system",
                  PhoneNumber = "07563237582",
                  City = "Leeds",
                  PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                  EmailConfirmed = true
              }); 
        }
    }
}