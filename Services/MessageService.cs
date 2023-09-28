namespace HelloBelle.Services;

public interface IMessageService
{
    string GetMessageForTheDay();
}

public class MessageService: IMessageService
{
    public string GetMessageForTheDay()
    {
        return "Hello Belle";
    }
}