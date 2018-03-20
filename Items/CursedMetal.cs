using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class CursedMetal : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Emanates the absolute most putrid aura.");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 5, 50, 0);
            item.rare = 9;
			item.maxStack = 99;

        }  
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CursedEssence", 1);
			recipe.AddIngredient(mod, "EvilEssence", 1);
			recipe.AddIngredient(ItemID.Obsidian, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CursedEssence", 1);
			recipe.AddIngredient(mod, "VileEssence", 1);
			recipe.AddIngredient(ItemID.Obsidian, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}  
    }
}