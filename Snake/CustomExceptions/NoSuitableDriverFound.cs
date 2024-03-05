namespace Snake.CustomExceptions;

public class NoSuitableDriverFound(string message) : Exception(message);