// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using JustLearn.Services.Api.Brokers.Loggings;
using JustLearn.Services.Api.Brokers.Storages;
using JustLearn.Services.Api.Models.Profiles;
using JustLearn.Services.Api.Services.Foundations.Profiles;
using Moq;
using Tynamix.ObjectFiller;
using Xeptions;

namespace JustLearn.Services.Tests.Unit.Services.Foundations.Profiles
{
    public partial class ProfileServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly IProfileService profileService;

        public ProfileServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();

            this.profileService = new ProfileService(
                storageBroker: this.storageBrokerMock.Object,
                loggingBroker: this.loggingBrokerMock.Object);
        }

        private static DateTimeOffset GetRandomDateTime() =>
            new DateTimeRange(earliestDate: new DateTime()).GetValue();

        private static Profile CreateRandomProfile() =>
            CreateProfileFiller(dateTime: GetRandomDateTime()).Create();

        private static Expression<Func<Xeption, bool>> SameExceptionAs(Exception expectedException)
        {
            return actualException =>
                actualException.Message == expectedException.Message
                && actualException.InnerException.Message == expectedException.InnerException.Message;
        }

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
