// -----------------------------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// -----------------------------------------------------------------------

using System.Threading.Tasks;

namespace JustLearn.Services.Tests.Acceptance.Brokers
{
    public partial class JustLearnApiBroker
    {
        private const string HomeRelativeUrl = "api/home";

        public async ValueTask<string> GetHomeMessageAsync() =>
            await this.apiFactoryClient.GetContentStringAsync(HomeRelativeUrl);
    }
}
