// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using Xeptions;

namespace JustLearn.Services.Api.Models.Profiles.Exceptions
{
    public class ProfileValidationException : Xeption
    {
        public ProfileValidationException(Exception innerException)
           : base(message: "Invalid input, contact support.", innerException)
        { }
    }
}
