namespace Fiorella.Persistence.Exceptions;
public interface IBaseExceptions
{
    public int StatusCode { get; set; }
    public string CustomMessage { get; set; }
}
