using Lands.Interfaces;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

namespace Lands.Data
{
    public class DbContext : IDisposable
    {
        public SQLiteConnection Db { get; private set; }

        public DbContext()
        {
            var dir = DependencyService.Get<ISQLitePlatform>();
            Db = new SQLiteConnection(dir.GetPath());
        }

        public void Migrate()
        {
            
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}