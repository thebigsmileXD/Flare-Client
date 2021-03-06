﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.CraftSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Gamemode : Module
    {
        public int inventoryState = SDK.instance.player.viewCreativeItems;
        public int savedGamemode;
        public Gamemode() : base("Gamemode", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
            RegisterSliderSetting("Mode", 0, 1, 2);
        }

        public override void onEnable()
        {
            base.onEnable();
            savedGamemode = SDK.instance.player.currentGamemode;
            inventoryState = SDK.instance.player.viewCreativeItems;
            SDK.instance.player.currentGamemode = sliderSettings[0].value;
            if(sliderSettings[0].value == 1) SDK.instance.player.viewCreativeItems = 1;
        }

        public override void onDisable()
        {
            base.onDisable();
            SDK.instance.player.currentGamemode = savedGamemode;
            SDK.instance.player.viewCreativeItems = inventoryState;
        }
    }
}
