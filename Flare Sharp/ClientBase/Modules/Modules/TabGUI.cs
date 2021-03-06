﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.UI;
using Flare_Sharp.UI.TabUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class TabGUI : Module
    {
        public TabGUI() : base("TabGUI", CategoryHandler.registry.categories[3], (char)0x07, true)
        {
        }
        public override void onEnable()
        {
            base.onEnable();
            OverlayHost.ui.Paint += drawUI;
        }

        private void drawUI(object sender, PaintEventArgs e)
        {
            if (enabled)
            {
                TabUiHandler.instance.renderTUI(e.Graphics);
            }
        }
    }
}
