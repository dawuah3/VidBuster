namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0ca7afc8-0342-45ad-8d35-64fe5005182e', N'g@vidly.com', 0, N'AMLEupdoTIY8K/YO6nPPyOsKBqj7uT04RMe57C3gh81qiZde0gsbu+6a3NjdPLEOzg==', N'e4a60a4c-9a5b-4a20-a317-4496f88f3a9b', NULL, 0, 0, NULL, 1, 0, N'g@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3a850825-0ae0-4d48-8a83-5c48e9d24b3e', N'derrick_awuah@aol.com', 0, N'AN0MzuUdEQZDkJUIHqG3HEavN0VnwvpH4OaK2NtqvLPphH2HJpnLHgkn1M1eIhR+8Q==', N'89ceeb26-5aaa-47f2-8979-660c079f5692', NULL, 0, 0, NULL, 1, 0, N'derrick_awuah@aol.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'de20c46c-78f9-4e80-925f-6f3a5de9f1c9', N'guest@vidly.com', 0, N'ABiLWaP6TdIxXzwEbMmUxfCx9+VE6ioTywnrVL536UDP0OI4igawWMPBHqEG76aJyw==', N'61a3f546-f98f-40e5-99c6-2e7c6fc1ca77', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'947b598e-cc70-4acb-b2b1-961e2de922c9', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0ca7afc8-0342-45ad-8d35-64fe5005182e', N'947b598e-cc70-4acb-b2b1-961e2de922c9')
            ");

                    
        }
        
        public override void Down()
        {
        }
    }
}
