// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using JustLearn.Services.Api.Brokers.Storages;
using JustLearn.Services.Api.Models.Profiles;
using JustLearn.Services.Api.Services.Foundations.Profiles;
using Moq;
using Tynamix.ObjectFiller;

namespace JustLearn.Services.Tests.Unit.Services.Foundations.Profiles
{
    public partial class ProfileServiceTests
    {
        private readonly IProfileService profileService;
        private readonly Mock<IStorageBroker> storageBrokerMock;

        public ProfileServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.profileService = new ProfileService(
                storageBroker: this.storageBrokerMock.Object);
        }

        private static DateTimeOffset GetRandomDateTime() =>
            new DateTimeRange(earliestDate: new DateTime()).GetValue();

        private static Profile CreateRandomProfile() =>
            CreateProfileFiller(dateTime: GetRandomDateTime()).Create();

        private static Filler<Profile> CreateProfileFiller(DateTimeOffset dateTime)
        {
            var filler = new Filler<Profile>();
            Guid profileId = Guid.NewGuid();

            filler.Setup()
                .OnType<DateTimeOffset>().Use(dateTime);

            return filler;
        }
    }
}
