using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class GnarlyTooth : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Twisted tooth of a truly horrible monster. The state suggests extremely old age.");
		}
        public override void SetDefaults()
        {        
            item.width = 24;
            item.height = 28;
            item.value = Item.sellPrice(0, 2, 0, 45);
            item.rare = 6;
			item.maxStack = 99;

        }      
    }
}