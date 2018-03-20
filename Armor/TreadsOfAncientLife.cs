using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class TreadsOfAncientLife : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Life is really simple, but we insist on making it complicated."
				+ "\nIncreased hp regen and movement speed."
				+ "\nFall damage immunity."
                + "\nRelease friendly spores around you."
                + "\n+1 max sentries.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(1, 20, 0, 0);
			item.rare = 9;
			item.defense = 35;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.3f;
			player.lifeRegen += 2;
			player.maxTurrets += 1;
            player.noFallDmg = true;
			player.maxRunSpeed += 0.3f;
            player.sporeSac = true;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "AncientLifewood", 75);
			recipe.AddIngredient(ItemID.LifeFruit, 2);
			recipe.AddIngredient(ItemID.LifeCrystal, 2);
			recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}