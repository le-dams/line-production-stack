using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoMetall
{
    class Config
    {
        // Production
        public static int MAIN_HEIGHT_MIN = 40;
        public static int MAIN_HEIGHT_MAX = 240;

        public static int MAIN_LENGTH_MIN = 1000;
        public static int MAIN_LENGTH_MAX = 14000;

        public static int MAIN_WIDTH_MIN = 800;
        public static int MAIN_WIDTH_MAX = 1400;

        // Glue
        public static int GLUE_SPEED_MAX = 30;
        public static int GLUE_SPEED_RESET = 200;
        public static int GLUE_RINSE_TOP_TIME = 25;
        public static int GLUE_RINSE_BOTTOM_TIME = 20;
    }
}
