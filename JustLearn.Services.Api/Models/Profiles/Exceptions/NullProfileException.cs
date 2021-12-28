// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using Xeptions;

namespace JustLearn.Services.Api.Models.Profiles.Exceptions
{
    public class NullProfileException : Xeption
    {
        public NullProfileException()
            : base(message: "The profile is null.")
        { }
    }
}
