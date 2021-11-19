// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using JustLearn.Services.Tests.Acceptance.Brokers;
using Xunit;

namespace JustLearn.Services.Tests.Acceptance.Apis.Home
{
    [Collection(nameof(ApiTestCollection))]
    public partial class HomeApiTests
    {
        private readonly JustLearnApiBroker justLearnApiBroker;

        public HomeApiTests(JustLearnApiBroker justLearnApiBroker) =>
            this.justLearnApiBroker = justLearnApiBroker;
    }
}
