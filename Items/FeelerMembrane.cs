using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class FeelerMembrane : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Sensory organ carefully pulled off a horrible monster. Writhes and reacts to movement.");
		}
        public override void SetDefaults()
        {        
            item.width = 24;
            item.height = 28;
            item.value = Item.sellPrice(0, 4, 27, 45);
            item.rare = 3;
			item.maxStack = 99;

        }      
    }
}