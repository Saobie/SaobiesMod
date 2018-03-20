using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class HorribleClump : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Clump of ghastly flesh. Very gross.");
		}
        public override void SetDefaults()
        {        
            item.width = 24;
            item.height = 28;
            item.value = Item.sellPrice(0, 0, 27, 45);
            item.rare = 3;
			item.maxStack = 99;

        }      
    }
}