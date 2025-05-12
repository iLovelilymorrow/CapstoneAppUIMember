using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneAppUIMember.Helpers {
    public static class UIScaler
    {
        public static double screenWidth => DeviceDisplay.MainDisplayInfo.Width;
        public static double screenDensity => DeviceDisplay.MainDisplayInfo.Density;

        public static double fontSizeByDensity => 50 / screenDensity;
        public static double forty => 40 / screenDensity;
        public static double thirty => 30 / screenDensity;
        public static double imageSizeByDensity => 105 / screenDensity;
    }
}