using HelloBelle.Services;
using Xunit;

namespace HelloBelle.Tests.Services;

public class MessageServiceTests
{
    private readonly MessageService _messageService;

    public MessageServiceTests()
    {
        _messageService = new MessageService();
    }
    
    [Fact]
    public void WhenNoServicePlanFeatures_ThenReturnError()
    {
        const string expected = "Hello Belle";
        var result = _messageService.GetMessageForTheDay();

        Assert.Equal(expected, result);
    }
}