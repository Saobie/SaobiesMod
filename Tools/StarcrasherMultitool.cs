using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Tools
{
    public class StarcrasherMultitool : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Multiple tools fused together using the stars. Functions as a hammer, axe, and pickaxe.");
		}
        public override void SetDefaults()
        {
  
            item.damage = 120;          
            item.melee = true;
            item.width = 20;
            item.height = 12;
            item.useTime = 10;
            item.useAnimation = 10;
            item.channel = true;
            item.noUseGraphic = false;
            item.melee = true;
            item.pick = 230;
			item.hammer = 230;
			item.axe = 230;
            item.tileBoost++;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.buyPrice(0, 85, 20, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 9);
			recipe.AddIngredient(ItemID.LunarBar, 3);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.LunarHamaxeNebula, 1);
			recipe.AddIngredient(ItemID.NebulaPickaxe, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 9);
			recipe.AddIngredient(ItemID.LunarBar, 3);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.LunarHamaxeSolar, 1);
			recipe.AddIngredient(ItemID.SolarFlarePickaxe, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 9);
			recipe.AddIngredient(ItemID.LunarBar, 3);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.LunarHamaxeVortex, 1);
			recipe.AddIngredient(ItemID.VortexPickaxe, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 9);
			recipe.AddIngredient(ItemID.LunarBar, 3);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.LunarHamaxeStardust, 1);
			recipe.AddIngredient(ItemID.StardustPickaxe, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
    }
}