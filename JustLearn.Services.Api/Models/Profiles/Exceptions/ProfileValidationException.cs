// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using Xeptions;

namespace JustLearn.Services.Api.Models.Profiles.Exceptions
{
    public class ProfileValidationException : Xeption
    {
        public ProfileValidationException(Xeption innerException)
           : base(message: "Please fix the errors and try again.", innerException)
        { }
    }
}
