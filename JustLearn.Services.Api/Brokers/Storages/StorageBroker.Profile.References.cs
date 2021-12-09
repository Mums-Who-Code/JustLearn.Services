// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using JustLearn.Services.Api.Models.Profiles;
using Microsoft.EntityFrameworkCore;

namespace JustLearn.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void SetProfileReferences(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
                .HasOne(profile => profile.CreatedByUser)
                .WithMany(user => user.CreatedProfiles)
                .HasForeignKey(profile => profile.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Profile>()
                .HasOne(profile => profile.UpdatedByUser)
                .WithMany(user => user.UpdatedProfiles)
                .HasForeignKey(profile => profile.UpdatedBy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
