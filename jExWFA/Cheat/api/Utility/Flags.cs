using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    class Flags
    {
        public static int FL_IN_AIR_STAND               = 256;
        public static int FL_ON_GROUND                  = 257;
        public static int FL_IN_AIR_MOVING_TO_STAND     = 258;
        public static int FL_ON_GROUND_MOVING_TO_STAND  = 259;
        public static int FL_IN_AIR_MOVING_TO_CROUCH    = 260;
        public static int FL_ON_GROUND_MOVING_TO_CROUCH = 261;
        public static int FL_IN_AIR_CROUCHED            = 262;
        public static int FL_ON_GROUND_CROUCHED         = 263;
        public static int FL_IN_WATER                   = 1280;
        public static int FL_IN_PUDDLE                  = 1281;
        public static int FL_IN_WATER_CROUCHED          = 1286;
        public static int FL_IN_PUDDLE_CROUCHED         = 1287;
    }
}
