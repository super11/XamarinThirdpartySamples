namespace Xamarin.Utilities.Core.Services
{
    public interface IJavascriptService
    {
        IJavascriptInstance CreateInstance();
    }

    public interface IJavascriptInstance
    {
        string Execute(string script);
    }
}