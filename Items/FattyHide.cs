using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class FattyHide : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Lardy clump of flesh. Must be useful for insulating heat.");
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