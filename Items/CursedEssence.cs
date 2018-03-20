using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class CursedEssence : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It feels utterly malignant.");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.buyPrice(0, 3, 60, 45);
            item.rare = 9;
			item.maxStack = 99;

        }      
		
    }
}