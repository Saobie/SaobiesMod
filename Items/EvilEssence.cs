using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class EvilEssence : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Manifested, tangible evil. Has an otherwordly aura.");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.buyPrice(0, 0, 60, 45);
            item.rare = 6;
			item.maxStack = 99;

        }      
		
    }
}