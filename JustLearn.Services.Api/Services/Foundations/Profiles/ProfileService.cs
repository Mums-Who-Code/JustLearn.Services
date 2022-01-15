// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using JustLearn.Services.Api.Brokers.Loggings;
using JustLearn.Services.Api.Brokers.Storages;
using JustLearn.Services.Api.Models.Profiles;

namespace JustLearn.Services.Api.Services.Foundations.Profiles
{
    public partial class ProfileService : IProfileService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public ProfileService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public ValueTask<Profile> AddProfileAsync(Profile profile) =>
           TryCatch(async () =>
           {
               ValidateInput(profile);

               return await this.storageBroker.InsertProfileAsync(profile);
           });
    }
}
