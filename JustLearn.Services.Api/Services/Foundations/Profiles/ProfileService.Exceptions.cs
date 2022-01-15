// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using JustLearn.Services.Api.Models.Profiles;
using JustLearn.Services.Api.Models.Profiles.Exceptions;
using Xeptions;

namespace JustLearn.Services.Api.Services.Foundations.Profiles
{
    public partial class ProfileService
    {
        private delegate ValueTask<Profile> ReturningProfileFunction();

        private async ValueTask<Profile> TryCatch(ReturningProfileFunction returningProfileFunction)
        {
            try
            {
                return await returningProfileFunction();
            }
            catch (NullProfileException nullProfileException)
            {
                throw CreateAndLogValidationException(nullProfileException);
            }
        }

        private ProfileValidationException CreateAndLogValidationException(Xeption exception)
        {
            var profileValidationException = new ProfileValidationException(exception);
            this.loggingBroker.LogError(profileValidationException);

            return profileValidationException;
        }
    }
}
