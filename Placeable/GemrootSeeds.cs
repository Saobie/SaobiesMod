using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace SaobiesMod.Items.Placeable
{
	public class GemrootSeeds : ModItem
	{
		public override void SetDefaults()
		{
			item.autoReuse = true;
			item.useTurn = true;
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 10;
			item.maxStack = 99;
			item.consumable = true;
			item.placeStyle = 0;
			item.width = 12;
			item.height = 14;
			item.value = 80;
			item.createTile = mod.TileType<Tiles.Gemroot>();
		}
		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CrushedGemDust", 1);
			recipe.AddIngredient(ItemID.DaybloomSeeds, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CrushedGemDust", 1);
			recipe.AddIngredient(ItemID.MoonglowSeeds, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CrushedGemDust", 1);
			recipe.AddIngredient(ItemID.BlinkrootSeeds, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CrushedGemDust", 1);
			recipe.AddIngredient(ItemID.DeathweedSeeds, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CrushedGemDust", 1);
			recipe.AddIngredient(ItemID.FireblossomSeeds, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CrushedGemDust", 1);
			recipe.AddIngredient(ItemID.WaterleafSeeds, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CrushedGemDust", 1);
			recipe.AddIngredient(ItemID.ShiverthornSeeds, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}