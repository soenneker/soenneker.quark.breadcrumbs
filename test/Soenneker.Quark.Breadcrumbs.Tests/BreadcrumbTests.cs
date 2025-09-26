using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Breadcrumbs.Tests;

[Collection("Collection")]
public sealed class BreadcrumbTests : FixturedUnitTest
{
    public BreadcrumbTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
