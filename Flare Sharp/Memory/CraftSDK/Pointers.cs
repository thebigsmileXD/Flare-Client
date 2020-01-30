﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.CraftSDK
{
    public class Pointers
    {
        public static UInt64 entityFacing()
        {
            UInt64[] offs = { 0xA8, 0x18, 0x130, 0x540, 0x0, 0x870 };
            return MCM.readInt64(MCM.baseEvaluatePointer(0x02FF8E38, offs));
        }
        public static UInt64 mousePitch()
        {
            UInt64[] offs = { 0x30, 0xE0, 0x28, 0x30, 0x168, 0x0, 0x14 };
            return MCM.baseEvaluatePointer(0x03020990, offs);
        }
        public static UInt64 mouseYaw()
        {
            UInt64[] offs = { 0x30, 0xE0, 0x28, 0x30, 0x168, 0x0, 0x10 };
            return MCM.baseEvaluatePointer(0x03020990, offs);
        }
        public static UInt64 playerSpeed()
        {
            UInt64[] offs = { 0x30, 0xF8, 0x410, 0x18, 0x1F0, 0x9C };
            return MCM.baseEvaluatePointer(0x03020990, offs);
        }
        public static UInt64 UI()
        { 
            UInt64[] offs = { 0x200, 0x128, 0x40, 0x8, 0x248 };
            return MCM.baseEvaluatePointer(0x02FA94F0, offs); //Not being used
        }
        public static int attackSwing = 0x102B81E; //v1.14.2
        public static int handSwingPacket = 0x8A8E84; //v1.14.2
        public static int rapidPlace = 0x102B7A0; //v1.14.2
        public static int autoSprint = 0x1A628C0; //v1.14.2
        public static int criticalsPacket = 0xFD9266; //v1.14.2
        public static int showCoordinates = 0x6015BD; //v1.14.2
        public static int blockFace = 0x5D3F82; //v1.14.2
        public static int noPacket = 0xF9F7DD; //v1.14.2
        public static int movementPacket = 0x8AB7E7; //V1.14.2
        public static int invalidMovementPacket = 0xFD923B; //v1.14.2
        public static int NoSlowDown1 = 0x1A629C9; //v1.14.2
        public static int NoSlowDown2 = 0xF79976; //v1.14.2
        public static int NoKnockBackX = 0x1217C72; //v1.14.2
        public static int NoKnockBackY = 0x1217C7B; //v1.14.2
        public static int NoKnockBackZ = 0x1217C84; //v1.14.2
        public static int webTick = 0x120ECA5; //v1.14.2
    }
}
