// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using JustLearn.Services.Api.Models.Profiles;

namespace JustLearn.Services.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Profile> InsertProfileAsync(Profile profile);
    }
}
