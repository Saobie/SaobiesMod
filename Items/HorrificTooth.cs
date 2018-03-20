using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class HorrificTooth : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tooth pulled from the jaws of a horrible monster. The size suggests it hunts rather large prey...");
		}
        public override void SetDefaults()
        {        
            item.width = 24;
            item.height = 28;
            item.value = Item.sellPrice(0, 2, 0, 45);
            item.rare = 3;
			item.maxStack = 99;

        }      
    }
}