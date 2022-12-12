using DDD.Foundations;

namespace DDD.Primitives.Messages;

public abstract record class Message : Enumeration
{
    public int Code => Id;
    public string? Text { get; init; }

    protected Message(int code, string name, string text)
         => (Id, Name, Text) = (code, name, text);
}
