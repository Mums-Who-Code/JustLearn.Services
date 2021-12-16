// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using JustLearn.Services.Api.Models.Profiles;

namespace JustLearn.Services.Api.Services.Foundations.Profiles
{
    public interface IProfileService
    {
        ValueTask<Profile> AddProfileAsync(Profile profile);
    }
}
