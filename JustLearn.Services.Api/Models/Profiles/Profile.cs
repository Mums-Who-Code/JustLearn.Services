// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System;
using JustLearn.Services.Api.Models.Users;

namespace JustLearn.Services.Api.Models.Profiles
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ProfileType Type { get; set; }
        public ProfileStatus Status { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public int Renewed { get; set; }

        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

        public Guid CreatedBy { get; set; }
        public User CreatedByUser { get; set; }

        public Guid UpdatedBy { get; set; }
        public User UpdatedByUser { get; set; }
    }
}
