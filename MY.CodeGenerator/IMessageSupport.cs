namespace MY.CodeGenerator
{
    public interface IMessageSupport
    {
        bool Message(string inputMessage, string extraData, out string outputMessage);
    }
}
