// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using JustLearn.Services.Api.Models.Profiles;
using JustLearn.Services.Api.Models.Profiles.Exceptions;
using Moq;
using Xunit;

namespace JustLearn.Services.Tests.Unit.Services.Foundations.Profiles
{
    public partial class ProfileServiceTests
    {
        [Fact]
        public async Task ShouldThrowValidationExceptionOnAddIfProfileIsNullAndLogItAsync()
        {
            //given
            Profile nullArtist = null;
            var nullArtistException = new NullProfileException();

            var expectedArtistValidationException =
               new ProfileValidationException(nullArtistException);

            //when
            ValueTask<Profile> addArtistTask =
                this.profileService.AddProfileAsync(nullArtist);

            //then
            await Assert.ThrowsAsync<ProfileValidationException>(() =>
                addArtistTask.AsTask());

            this.loggingBrokerMock.Verify(broker =>
                broker.LogError(It.Is(
                    SameExceptionAs(expectedArtistValidationException))),
                        Times.Once);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertProfileAsync(It.IsAny<Profile>()),
                    Times.Never);

            this.loggingBrokerMock.VerifyNoOtherCalls();
            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}