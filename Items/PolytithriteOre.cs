using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class PolytithriteOre : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Very rare natural combination of various minerals. Predominantly titanium and adamantite.");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 80, 0);
            item.rare = 7;
			item.maxStack = 999;

        }      
    }
}