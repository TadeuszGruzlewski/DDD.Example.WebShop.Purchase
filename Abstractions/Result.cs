namespace DDD.Foundations;

public abstract record class Result;
//public record class Success(object? Object) : Result;
public record class Success() : Result;
public record class Error(string Message) : Result;
