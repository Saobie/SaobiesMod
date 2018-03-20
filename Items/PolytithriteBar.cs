using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class PolytithriteBar : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Refined polytithrite, highly durable in this molded state. Can be used for crafting..");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 7;
			item.maxStack = 99;

        }      
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PolytithriteOre", 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
    }
}