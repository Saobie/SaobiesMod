using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Consumables
{
	public class EssenceOfAncientLife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Essence Of Ancient Life");
			Tooltip.SetDefault("Fully restores HP without causing potion sickness."
						+ "\nThe potion has a reuse delay of 2 minutes.");
		}
		 public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 9;
			item.reuseDelay = 7200;         
        }
       
        public override bool UseItem(Player player)
		{
			player.statLife += 5000;
			player.HealEffect(5000);

            return true;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("AncientLifeShard"), 1);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.AddIngredient(ItemID.Moonglow, 5);
			recipe.AddIngredient(ItemID.SuperHealingPotion, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}  
    }
}