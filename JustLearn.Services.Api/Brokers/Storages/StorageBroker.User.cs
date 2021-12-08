// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using JustLearn.Services.Api.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace JustLearn.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<User> Users { get; set; }
    }
}
