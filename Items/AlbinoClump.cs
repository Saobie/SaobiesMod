using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class AlbinoClump : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Clump of white flesh. Extremely gross.");
		}
        public override void SetDefaults()
        {        
            item.width = 24;
            item.height = 28;
            item.value = Item.sellPrice(0, 0, 47, 45);
            item.rare = 6;
			item.maxStack = 99;

        }      
    }
}