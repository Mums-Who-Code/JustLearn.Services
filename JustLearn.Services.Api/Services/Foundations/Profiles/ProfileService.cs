// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using JustLearn.Services.Api.Brokers.Storages;
using JustLearn.Services.Api.Models.Profiles;

namespace JustLearn.Services.Api.Services.Foundations.Profiles
{
    public class ProfileService : IProfileService
    {
        private readonly IStorageBroker storageBroker;

        public ProfileService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Profile> AddProfileAsync(Profile profile) =>
            await this.storageBroker.InsertProfileAsync(profile);
    }
}
