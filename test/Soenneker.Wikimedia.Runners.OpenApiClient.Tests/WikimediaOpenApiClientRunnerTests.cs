using Soenneker.Tests.HostedUnit;

namespace Soenneker.Wikimedia.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WikimediaOpenApiClientRunnerTests : HostedUnitTest
{
    public WikimediaOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
