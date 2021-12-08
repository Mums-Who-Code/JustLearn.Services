// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using JustLearn.Services.Api.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace JustLearn.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var serviceAdminUser = new User
            {
                Id = Guid.Parse("117c3dbf-e77c-4969-89da-1e4e54e641d0"),
                Name = "Admin"
            };

            modelBuilder.Entity<User>().HasData(serviceAdminUser);
        }
    }
}
