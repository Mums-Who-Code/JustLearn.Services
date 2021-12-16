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
            Profile randomCategory = CreateRandomProfile();
            Profile inputCategory = randomCategory;
            Profile storageCategory = inputCategory;
            Profile expectedCategory = storageCategory.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertProfileAsync(inputCategory))
                    .ReturnsAsync(storageCategory);

            // when
            Profile actualCategory =
                await this.profileService.AddProfileAsync(inputCategory);

            // then
            actualCategory.Should().BeEquivalentTo(expectedCategory);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertProfileAsync(inputCategory),
                    Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
