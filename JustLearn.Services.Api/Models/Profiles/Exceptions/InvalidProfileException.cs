// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using Xeptions;

namespace JustLearn.Services.Api.Models.Profiles.Exceptions
{
    public class InvalidProfileException : Xeption
    {
        public InvalidProfileException()
            : base(message: "Invalid Profile, fix the error and try again!")
        { }
    }
}
