using Xamarin.Forms;

[assembly: Dependency(typeof(Lands.Droid.Implementations.CloseApplicationAndroidPlatform))]
namespace Lands.Droid.Implementations
{
    using Lands.Interfaces;

    class CloseApplicationAndroidPlatform : ICloseApplicationPlatform
    {
        public void Close()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}