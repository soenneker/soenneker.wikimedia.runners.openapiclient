using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Wikimedia.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class WikimediaOpenApiClientRunnerTests : FixturedUnitTest
{
    public WikimediaOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
