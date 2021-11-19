// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using Xunit;

namespace JustLearn.Services.Tests.Acceptance.Brokers
{
    [CollectionDefinition(nameof(ApiTestCollection))]
    public class ApiTestCollection : ICollectionFixture<JustLearnApiBroker>
    {
    }
}
