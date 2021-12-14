// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using JustLearn.Services.Api.Models.Profiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace JustLearn.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Profile> Profiles { get; set; }

        public async ValueTask<Profile> InsertProfileAsync(Profile profile)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Profile> entityEntry =
                await broker.Profiles.AddAsync(profile);

            await broker.SaveChangesAsync();

            return entityEntry.Entity;
        }
    }
}
