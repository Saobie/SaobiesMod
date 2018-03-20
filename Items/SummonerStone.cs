using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class SummonerStone : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Stone with strong affinity towards summoners. Consumed for certain spells.");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = 2;
			item.maxStack = 999;
			item.consumable = true;
			item.ammo = item.type;
        }      
    }
}