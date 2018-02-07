using System.Globalization;

namespace Lands.Interfaces
{
    public interface ILocalizePlatform
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);
    }
}
