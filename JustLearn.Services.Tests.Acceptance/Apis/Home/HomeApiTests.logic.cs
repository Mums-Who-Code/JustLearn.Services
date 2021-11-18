// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace JustLearn.Services.Tests.Acceptance.Apis.Home
{
    public partial class HomeApiTests
    {
        [Fact]
        public async Task ShouldReturnHomeMessageAsync()
        {
            //Given
            string expectedHomeMessage =
                "Hello Mums! This is my first launch!";

            //When
            string actualHomeMessage =
                await this.justLearnApiBroker.GetHomeMessageAsync();

            //Then
            actualHomeMessage.Should().BeEquivalentTo(expectedHomeMessage);
        }
    }
}
