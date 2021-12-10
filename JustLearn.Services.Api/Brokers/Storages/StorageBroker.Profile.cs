// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using JustLearn.Services.Api.Models.Profiles;
using Microsoft.EntityFrameworkCore;

namespace JustLearn.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Profile> Profiles { get; set; }
    }
}
