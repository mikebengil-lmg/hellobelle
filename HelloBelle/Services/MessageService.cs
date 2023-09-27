namespace HelloBelle.Services;

public interface IMessageService
{
    string GetMessageForTheDay();
}

public class MessageService: IMessageService
{
    public string GetMessageForTheDay()
    {
        //just printing my name
        return "Hello Belle";
    }
}