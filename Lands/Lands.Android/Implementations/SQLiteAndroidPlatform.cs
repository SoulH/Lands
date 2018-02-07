using Xamarin.Forms;

[assembly: Dependency(typeof(Lands.Droid.Implementations.SQLiteAndroidPlatform))]
namespace Lands.Droid.Implementations
{
    using Lands.Interfaces;
    using System.IO;

    public class SQLiteAndroidPlatform : ISQLitePlatform
    {
        public string GetPath(string dbName = "lands.db3")
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
        }
    }
}