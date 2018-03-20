using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class GhastlyHeart : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Heart of a horrible monster. Holding it makes you feel like youre not yourself anymore.");
		}
        public override void SetDefaults()
        {        
            item.width = 40;
            item.height = 40;
            item.value = Item.sellPrice(0, 12, 27, 45);
            item.rare = 3;
			item.maxStack = 99;

        }      
    }
}