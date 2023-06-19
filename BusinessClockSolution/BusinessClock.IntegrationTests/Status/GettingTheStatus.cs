using Alba;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

public class GettingTheStatus
{
    [Fact]
    public async Task OpenHours()
    {
        var host = await AlbaHost.For<Program>();



        var response = await host.Scenario(api =>
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk();
        });



        Assert.NotNull(response); // did we get something back?
        GetStatusResponse? responseMessage = response.ReadAsJson<GetStatusResponse>();
        Assert.NotNull(responseMessage);
        Assert.True(responseMessage.Open);
        Assert.Null(responseMessage.OpensAt);
    }
}
