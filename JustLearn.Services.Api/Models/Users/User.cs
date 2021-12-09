// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustLearn.Services.Api.Models.Profiles;

namespace JustLearn.Services.Api.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public IEnumerable<Profile> CreatedProfiles { get; set; }

        [JsonIgnore]
        public IEnumerable<Profile> UpdatedProfiles { get; set; }
    }
}
