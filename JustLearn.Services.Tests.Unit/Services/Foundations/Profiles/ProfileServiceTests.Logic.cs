// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using FluentAssertions;
using Force.DeepCloner;
using JustLearn.Services.Api.Models.Profiles;
using Moq;
using Xunit;

namespace JustLearn.Services.Tests.Unit.Services.Foundations.Profiles
{
    public partial class ProfileServiceTests
    {
        [Fact]
        public async Task ShouldAddProfileAsync()
        {
            // given
            Profile randomProfile = CreateRandomProfile();
            Profile inputProfile = randomProfile;
            Profile storageProfile = inputProfile;
            Profile expectedProfile = storageProfile.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertProfileAsync(inputProfile))
                    .ReturnsAsync(storageProfile);

            // when
            Profile actualProfile =
                await this.profileService.AddProfileAsync(inputProfile);

            // then
            actualProfile.Should().BeEquivalentTo(expectedProfile);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertProfileAsync(inputProfile),
                    Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
