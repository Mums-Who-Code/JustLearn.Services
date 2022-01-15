// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using JustLearn.Services.Api.Models.Profiles;
using JustLearn.Services.Api.Models.Profiles.Exceptions;

namespace JustLearn.Services.Api.Services.Foundations.Profiles
{
    public partial class ProfileService
    {
        private void ValidateInput(Profile profile)
        {
            if (profile == null)
            {
                throw new NullProfileException();
            }
        }
    }
}
