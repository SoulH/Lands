using System;
using System.Collections.Generic;
using System.Text;

namespace Platforms.Interfaces
{
    public interface ILocalizePlatform
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);
    }
}
