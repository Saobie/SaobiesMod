using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class StarBar : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("infused magical bar made from cosmic materials.");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 10, 50, 0);
            item.rare = 9;
			item.maxStack = 999;

        }  
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 3);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddIngredient(ItemID.FragmentStardust, 5);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}  
    }
}