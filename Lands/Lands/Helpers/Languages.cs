using Lands.Interfaces;
using Lands.Resources;
using Xamarin.Forms;

namespace Lands.Helpers
{
    public static class Languajes
    {
        static Languajes()
        {
            var ci = DependencyService.Get<ILocalizePlatform>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalizePlatform>().SetLocale(ci);
        }

        public static string Title { get { return Resource.Title; } }

        public static string Accept { get { return Resource.Accept; } }

        public static string Yes { get { return Resource.Yes; } }

        public static string No { get { return Resource.No; } }

    }

}
