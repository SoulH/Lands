namespace Lands.Interfaces
{
    public interface ISQLitePlatform
    {
        string GetPath(string dbName = "lands.db3");
    }
}
