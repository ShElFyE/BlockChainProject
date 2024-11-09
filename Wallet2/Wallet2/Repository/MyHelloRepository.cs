public class MyHelloRepository : IMyRepository
{
    public string GetTestMessage()
    {
        return "Test message from repository";
    }
}
