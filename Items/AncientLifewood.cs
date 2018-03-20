using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class AncientLifewood : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Ancient wood that breathes life and fortune, imbued with restorative properties"
					+ "\nYou just made this, but thanks to the manipulator, its aged and useful.");
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
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddIngredient(ItemID.LifeFruit, 1);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}  
    }
}