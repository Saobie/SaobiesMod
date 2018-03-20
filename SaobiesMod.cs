using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
//using ExampleMod.UI;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using System;


namespace SaobiesMod
{
    class SaobiesMod : Mod
    {

        public SaobiesMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
                AutoloadBackgrounds = true
            };
		}
    }
}
