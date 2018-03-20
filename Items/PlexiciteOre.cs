using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class PlexiciteOre : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Uncommon metallic minerak that somewhat resembles glass. Roughly as durable as steel.");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.buyPrice(0, 0, 60, 45);
            item.rare = 3;
			item.maxStack = 999;

        }      
    }
}