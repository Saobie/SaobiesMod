using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class CrushedGemDust : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Dust made from a crushed assortment of gems");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 2;
			item.maxStack = 999;

        }  
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddIngredient(ItemID.Topaz, 1);
			recipe.AddIngredient(ItemID.Emerald, 1);
			recipe.AddIngredient(ItemID.Sapphire, 1);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
    }
}